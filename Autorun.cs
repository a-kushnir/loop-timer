using System.Windows.Forms;
using Microsoft.Win32;

namespace Timer72
{
    public static class Autorun
    {
        private static RegistryKey RegistryKey(bool writable) => 
            Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        public static bool Enabled => 
            RegistryKey(false).GetValue(Application.ProductName) != null;

        public static void Update(bool enable)
        {
            if (enable)
            {
                RegistryKey(true).SetValue(Application.ProductName, Application.ExecutablePath);
            }
            else
            {
                RegistryKey(true).DeleteValue(Application.ProductName, false);
            }
        }
    }
}
