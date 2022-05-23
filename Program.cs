using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notifications_API
{
    static class Program
    {
        [DllImport("user32.dll")]
        static extern int GetForegroundWindow();
        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);
        [DllImport("user32.dll")]
        public static extern int SetForegroundWindow(int hwnd);


        public static int smoothning = 150;
        public static string title;
        public static int timeout;
        public static string message;

        public static int hWnd = GetForegroundWindow();

        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length < 3){
                MessageBox.Show("Usage: title timeout message");
                return;
            }

            string[] msg = new string[args.Length-2];
            for (int i = 0; i < args.Length; i++)
                if (i > 1) msg[i - 2] = args[i];

            title = args[0];
            timeout = int.Parse(args[1]);
            message = String.Join(" ", msg);

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Screen());
        }
    }
}
