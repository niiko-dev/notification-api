using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;

namespace Notifications_API
{
    public partial class Screen : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll")]
        public static extern int SetForegroundWindow(int hwnd);

        /* Make click thru */
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x80;  // Turn on WS_EX_TOOLWINDOW
                return cp;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            var style = GetWindowLong(this.Handle, -20);
            SetWindowLong(this.Handle, -20, style | 0x80000 | 0x20);
        }

        public Screen()
        {
            /* Make compatible for all systems */
            CheckForIllegalCrossThreadCalls = false;
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;

            InitializeComponent();
        }

        private void MoveNotification (int x, int y)
        {
            notification_bg.Location = new Point(x, y);
            notification_bar.Location = new Point(x, y);
            notification_title.Location = new Point(x + 2, y + 3);
            notification_message.Location = new Point(x + 6, y + 27);
        }

        private void Loop ()
        {
            while (true)
            {
                this.BringToFront();
                Thread.Sleep(1);
            }
        }

        private void Check ()
        {
            bool found = false;

            while (true)
            {
                if (this.IsHandleCreated)
                {
                    if (!found)
                    {
                        found = true;

                        

                        Thread.Sleep(Program.timeout);

                        for (int i = 0; i < Program.smoothning; i++)
                        {
                            this.Opacity -= (double)1 / (double)Program.smoothning;
                            Thread.Sleep(1000 / Program.smoothning);
                        }

                        Process.GetCurrentProcess().Kill();
                    } 
                }

                Thread.Sleep(1);
            }
        }

        private void Screen_Load(object sender, EventArgs e)
        {
            SetForegroundWindow(Program.hWnd);
            /* debug */
            Thread Key_Listener = new Thread(KeyListener.Listen);
            Key_Listener.Start();

            /* always on top fix */
            new Thread(Loop).Start();
            new Thread(Check).Start();

            /* get primary screen */
            GetScreen.screen scrn = GetScreen.Get();

            /* set style */
            notification.Size = new Size(scrn.w + 8, scrn.h + 28);
            this.BringToFront();
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.Red;
            this.TransparencyKey = this.BackColor;
            this.Location = new Point(scrn.x, scrn.y);
            this.Width = scrn.w;
            this.Height = scrn.h;

            /* set shi */
            notification_title.Text = Program.title;
            notification_message.Text = Program.message;

            /* test notification */

            MoveNotification(scrn.w - 20 - notification_bg.Width, scrn.h - 20 - notification_bg.Height);
        }
    }
}
