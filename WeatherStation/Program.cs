using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace WeatherStation
{
    static class Program
    {
        /// <summary>
        /// Mutex for controlling one app instance
        /// </summary>
        public static Mutex mutex = new Mutex(true, "{f6de2fec-0b0d-4613-aa00-422fd134e62a}");
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            
            if(mutex.WaitOne(TimeSpan.Zero, true)) 
            {
                //If program isn't already run...
                
                //Import settings from previously compiled versions
                AuxilaryProc.UpgradeSettings();

                //If it is first run chek for setup
                AuxilaryProc.CreateAutoStartLink();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());

                mutex.ReleaseMutex();
            }
            else
            {
                //if already run - set window to foreground
                Utils.SetCurrentWindowToForeground();
            }
        }
    }
}
