using System;
using System.Drawing;
using System.Windows.Forms;

namespace Timer72
{
    public partial class MainForm : Form
    {
        private const float OpacityMin = 0.35f;
        private const float OpacityMax = 0.85f;
        private const float OpacityOut = 1.00f;
        private readonly Animation _opacityAnimation;
        
        private const int ResetHours = 72;
        private readonly Timer _timer;

        // ReSharper disable once NotAccessedField.Local
        private readonly MovableForm _movableForm;

        private readonly AppSettings _settings;

        public MainForm()
        {
            InitializeComponent();

            _settings = new AppSettings();
            _settings.Load();

            if (_settings.WindowLocation.HasValue)
            {
                Location = _settings.WindowLocation.Value;
                StartPosition = FormStartPosition.Manual;
            }

            _opacityAnimation = new Animation(OpacityMin, 0.2f, 20, (sender, args) =>
            {
                Opacity = ((Animation)sender).Value;
            });

            _movableForm = new MovableForm(this, new Control[] {this, labelTimeLeft});

            _timer = new Timer(_settings.UtcTarget, ResetHours, (sender, args) =>
            {
                var t = (Timer) sender;
                var colon = t.Colon ? ":" : "\u200A\u200A"; // Hair space U+200A - The thinnest space in a typeface.
                labelTimeLeft.Text = $@"{t.Hours:00}{colon}{t.Minutes:00}";
                niMain.Text = t.Hours == 1 ? $@"{t.Hours} hour left" : $@"{t.Hours} hours left";

                var color = Color.FromArgb(t.TMinus ? 0x1D1D1D : 0xEE1111);
                color = Color.FromArgb(255, color);
                BackColor = color;
                //labelTimeLeft.BackColor = color;

                if (!t.TMinus)
                {
                    _opacityAnimation.Start(OpacityOut);
                    if (!Visible)
                        Show();
                }
            });

            labelTimeLeft.MouseWheel += LabelTimeLeftOnMouseWheel;
        }

        private void LabelTimeLeftOnMouseWheel(object sender, MouseEventArgs e)
        {
            var value = e.Delta < 0 ? -1 : 1;
            var hours = e.X < labelTimeLeft.Width / 2;
            _timer.AddTime(hours ? value : 0, hours ? 0 : value);
        }

        private void MainForm_MouseEnter(object sender, EventArgs e)
        {
            _opacityAnimation.Start(_timer.TMinus ? OpacityMax : OpacityOut);
        }

        private void MainForm_MouseLeave(object sender, EventArgs e)
        {
            if (!ClientRectangle.Contains(PointToClient(MousePosition)))
            {
                _opacityAnimation.Start(_timer.TMinus ? OpacityMin : OpacityOut);
            }
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            _timer.Reset();
            ActiveControl = null;
        }

        private void ResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _timer.Reset();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ContextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            autorunToolStripMenuItem.Checked = Autorun.Enabled;
            showToolStripMenuItem.Visible = !Visible;
            hideToolStripMenuItem.Visible = Visible;
        }

        private void HideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void ShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void AutorunToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Autorun.Update(!autorunToolStripMenuItem.Checked);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _settings.UtcTarget = _timer.UtcTarget;
            _settings.WindowLocation = Location;
            _settings.WindowVisible = Visible;
            _settings.Save();
        }

        protected override void OnLoad(EventArgs e)
        {
            if (_settings.WindowVisible.HasValue)
            {
                Visible = _settings.WindowVisible.Value;
            }

            base.OnLoad(e);
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cnsMain.Show(this, e.Location, ToolStripDropDownDirection.Default);
            }
        }
    }
}
