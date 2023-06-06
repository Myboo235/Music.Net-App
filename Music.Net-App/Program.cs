using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Music.Net_App.BLL;
using Music.Net_App.View;
using Music.Net_App.View.Admin;
using Music.Net_App.View.Artist;
using Music.Net_App.View.Listener;

namespace Music.Net_App
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new DashboardForm());
            Application.Run(new MainForm("Edsheeran@gmail.com", "Artist"));
        }
    }
}
