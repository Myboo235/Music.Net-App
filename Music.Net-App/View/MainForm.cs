using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music.Net_App.View
{
    public partial class MainForm : Form
    {
        

        public MainForm()
        {

            InitializeComponent();
            axWindowsMediaPlayer1.URL = @"C:\Users\Lenovo\Downloads\video.mp4";
            axWindowsMediaPlayer1.settings.setMode("loop", true);

        }

        private void LeftBar_MouseHover(object sender, EventArgs e)
        {
            Button buttonHover = (Button)sender;
            buttonHover.ForeColor = Color.White;
            buttonHover.BackColor = ColorTranslator.FromHtml("#777777");
        }
        private void LeftBar_MouseLeave(object sender, EventArgs e)
        {
            Button buttonLeft = (Button)sender;
            buttonLeft.ForeColor = ColorTranslator.FromHtml("#B2B2B2");
            buttonLeft.BackColor = ColorTranslator.FromHtml("#000000");
        }
    }
}
