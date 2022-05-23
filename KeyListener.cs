using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;

namespace Notifications_API
{
    public static class KeyListener
    {
        [DllImport("User32.dll")]
        public static extern bool GetAsyncKeyState(Keys key);

        public static void Listen ()
        {
            while (true)
            {
                if (GetAsyncKeyState(Keys.Insert))
                    Process.GetCurrentProcess().Kill();

                Thread.Sleep(100);
            }
        }
    }
}
