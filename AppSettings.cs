using System;
using System.Configuration;
using System.Drawing;
using System.Globalization;

namespace Timer72
{
    public class AppSettings
    {
        public DateTime? UtcTarget { get; set; }
        public Point? WindowLocation { get; set; }
        public bool? WindowVisible { get; set; }

        public void Load()
        {
            var appSettings = ConfigurationManager.AppSettings;

            UtcTarget = Convertors.ToNullableDateTime(appSettings.Get("UtcTarget"));
            WindowLocation = Convertors.ToNullablePoint(appSettings.Get("WindowLocation"));
            WindowVisible = Convertors.ToNullableBool(appSettings.Get("WindowVisible"));
        }

        public void Save()
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;

                Set(settings, "UtcTarget", Convertors.ToString(UtcTarget));
                Set(settings, "WindowLocation", Convertors.ToString(WindowLocation));
                Set(settings, "WindowVisible", Convertors.ToString(WindowVisible));

                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
            }
        }

        private static void Set(KeyValueConfigurationCollection settings, string key, string value)
        {
            if (settings[key] == null)
            {
                settings.Add(key, value);
            }
            else
            {
                settings[key].Value = value;
            }
        }

        private static class Convertors
        {
            private const string DateTimeFormatInfo = "yyyy-MM-dd HH:mm:ss";

            public static DateTime? ToNullableDateTime(string value)
            {
                if (value == null) return null;

                try
                {
                    return DateTime.ParseExact(value, DateTimeFormatInfo, CultureInfo.InvariantCulture);
                }
                catch (FormatException)
                {
                    return null;
                }
            }

            public static Point? ToNullablePoint(string value)
            {
                if (value == null) return null;

                try
                {
                    var coordinates = value.Split(',');
                    var x = ToNullableInt(coordinates[0]);
                    var y = ToNullableInt(coordinates[1]);
                    if (x.HasValue && y.HasValue)
                    {
                        return new Point(x.Value, y.Value);
                    }
                }
                catch (IndexOutOfRangeException)
                {
                }

                return null;
            }

            public static int? ToNullableInt(string value)
            {
                if (value == null) return null;

                try
                {
                    return int.Parse(value);
                }
                catch (FormatException)
                {
                }
                catch (OverflowException)
                {
                }

                return null;
            }

            public static bool? ToNullableBool(string value)
            {
                if (value == null) return null;

                try
                {
                    return bool.Parse(value);
                }
                catch (FormatException)
                {
                }
                catch (OverflowException)
                {
                }

                return null;
            }

            public static string ToString(DateTime? value)
            {
                return value?.ToString(DateTimeFormatInfo);
            }

            public static string ToString(Point? value)
            {
                return value.HasValue ? $"{value.Value.X},{value.Value.Y}" : null;
            }

            public static string ToString(int? value)
            {
                return value?.ToString();
            }

            public static string ToString(bool? value)
            {
                return value?.ToString();
            }
        }

    }
}
