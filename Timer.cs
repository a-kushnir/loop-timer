using System;
using System.Diagnostics.Eventing.Reader;
using FormTimer = System.Windows.Forms.Timer;

namespace Timer72
{
    public class Timer
    {
        public bool TMinus { get; private set; }
        public int Hours { get; private set; }
        public int Minutes { get; private set; }
        public bool Colon { get; private set; }
        public int ResetHours { get; private set; }

        public DateTime UtcTarget;

        // ReSharper disable once PrivateFieldCanBeConvertedToLocalVariable
        private readonly FormTimer _timer;

        public event EventHandler Update;

        public Timer(DateTime? utcTarget, int resetHours, EventHandler update)
        {
            ResetHours = resetHours;

            if (utcTarget != null)
            {
                UtcTarget = utcTarget.Value;
            }
            else
            {
                Reset();
            }

            _timer = new FormTimer
            {
                Enabled = true,
                Interval = 1000
            };
            _timer.Tick += (sender, args) => { Animate(true); };

            Update += update;
            Animate(true);
        }

        private void Animate(bool updateColon)
        {
            var now = DateTime.UtcNow;
            var timeSpan = UtcTarget - now;
            TMinus = UtcTarget > now;
            Hours = (int)Math.Floor(Math.Abs(timeSpan.TotalHours));
            Minutes = Math.Abs(timeSpan.Minutes);
            if (updateColon)
            {
                Colon = !Colon;
            }

            Update?.Invoke(this, EventArgs.Empty);
        }

        public void Reset()
        {
            UtcTarget = DateTime.UtcNow.AddHours(ResetHours + 1f/3600);
            Colon = false;
            Animate(true);
        }

        public void AddTime(int hours, int minutes)
        {
            UtcTarget = UtcTarget.AddMinutes(hours * 60 + minutes);
            Animate(false);
        }
    }
}
