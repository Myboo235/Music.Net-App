using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Music.Net_App.View
{
    public partial class MainForm : Form
    {
        

        public MainForm()
        {
            
            string directory = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug\", "");
            InitializeComponent();
            IntroVideo.URL = directory +  @"\Assets\Videos\video.mp4";
            IntroVideo.settings.setMode("loop", true );
            IntroVideo.settings.mute = true;
            
            /*        C: \Users\Lenovo\source\repos\Music\MusicApp\Music.Net - App\Assets\Musics\y2mate.com - DVRST  CLOSE EYES.mp3
            */
            axWindowsMediaPlayer1.URL = directory + @"\Assets\Musics\y2mate.com - DVRST  CLOSE EYES.mp3";
            axWindowsMediaPlayer1.Ctlcontrols.stop();
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
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FormMainMenu_Resize(object sender, EventArgs e)
        {
            /*if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
*/
            
            MenuBar.Height = this.Height;
            ContactBar.Height = this.Height;
            HomeLayout.Height= this.Height;
            
            HomeLayout.Size = new Size(this.Width - MenuBar.Width -ContactBar.Width- 30, this.Height);
            UserNav.Width = HomeLayout.Width - Button_Back.Width - Button_Next.Width- 120;

            IntroVideo.Width = VideoPanel.Width - 10;
            VideoPanel.Width= HomeLayout.Width;
            VideoPanel.Height= HomeLayout.Height/5;

            NavBar.Width = HomeLayout.Width;
            IntroVideo.Width = HomeLayout.Width;
            RecentPlayed.Width= HomeLayout.Width;
            TopMixes.Width = HomeLayout.Width;

            panel1.Width = HomeLayout.Width;
            axWindowsMediaPlayer1.Width = HomeLayout.Width- panel3.Width -20;

            /*ContactBar.Location = new Point(0,  ContactBar.Width + MenuBar.Width);*/
        }

        private void Button_Play_Click(object sender, EventArgs e)
        {
            if (Button_Play.IconChar.ToString() == "Play") {
                Button_Play.IconChar = IconChar.Pause;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else if (Button_Play.IconChar.ToString() == "Pause")
            {
                Button_Play.IconChar = IconChar.Play;
                axWindowsMediaPlayer1.Ctlcontrols.pause();
            }
        }
    }
}
