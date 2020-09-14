using System;
using FormTimer = System.Windows.Forms.Timer;

namespace LoopTimer
{
    public class Animation
    {
        private const float Tolerance = 0.001f;

        public float Value { get; private set; }
        public float Step { get; }
        public float Target { get; private set; }

        private readonly FormTimer _timer;

        public event EventHandler Update;

        public Animation(float value, float step, int interval, EventHandler update)
        {
            Value = value;
            Step = step;

            _timer = new FormTimer
            {
                Enabled = false,
                Interval = interval
            };
            _timer.Tick += (sender, args) => { Animate(); };

            Update += update;
            Update?.Invoke(this, EventArgs.Empty);
        }

        public void Start(float target)
        {
            if (Math.Abs(Target - target) < Tolerance)
                return;

            Target = target;
            _timer.Start();
            Animate();
        }

        private void Animate()
        {
            if (Value < Target)
            {
                Value += Step;
                if (Value > Target)
                    Value = Target;
            }
            else if (Value > Target)
            {
                Value -= Step;
                if (Value < Target)
                    Value = Target;
            }

            if (Math.Abs(Value - Target) < Tolerance)
            {
                _timer.Stop();
            }

            Update?.Invoke(this, EventArgs.Empty);
        }
    }
}
