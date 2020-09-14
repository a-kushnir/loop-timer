using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Timer72
{
    public class MovableForm
    {
        // ReSharper disable once IdentifierTypo
        // ReSharper disable once InconsistentNaming
        public const int WM_NCLBUTTONDOWN = 0xA1;
        // ReSharper disable once IdentifierTypo
        // ReSharper disable once InconsistentNaming
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        // ReSharper disable once InconsistentNaming
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public MovableForm(Form form, IEnumerable<Control> controls)
        {
            foreach (var control in controls)
            {
                control.MouseDown += (sender, args) =>
                {
                    if (args.Button != MouseButtons.Left) return;
                    ReleaseCapture();
                    SendMessage(form.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                };
            }
        }
    }
}
