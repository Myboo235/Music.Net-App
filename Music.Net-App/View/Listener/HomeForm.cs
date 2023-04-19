using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music.Net_App.View
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {

            string directory = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug\", "");
            InitializeComponent();
            IntroVideo.URL = directory + @"\Assets\Videos\video.mp4";
            IntroVideo.settings.setMode("loop", true);
            IntroVideo.settings.mute = true;

            /*        C: \Users\Lenovo\source\repos\Music\MusicApp\Music.Net - App\Assets\Musics\y2mate.com - DVRST  CLOSE EYES.mp3
            */

        }
        private void resize()
        {
            /*MenuBar.Height = this.Height;
            ContactBar.Height = this.Height;*/
            /*HomeLayout.Height = this.Height;
            HomeLayout.Width = this.Width*/;
            //MessageBox.Show(this.Width + this.Height + "");
            HomeLayout.Size = new Size(this.Width, this.Height);
            
            
            VideoPanel.Width = HomeLayout.Width-9;
            IntroVideo.Width = VideoPanel.Width;
            VideoPanel.Height = HomeLayout.Height / 3;

            IntroVideo.Width = HomeLayout.Width;
            RecentPlayed.Width = HomeLayout.Width;
            TopMixes.Width = HomeLayout.Width;

            /*panel1.Width = HomeLayout.Width;
            axWindowsMediaPlayer1.Width = HomeLayout.Width - panel3.Width - 20;*/
            /*if (currentChildForm != null)
            {
                currentChildForm.Width = HomeLayout.Width;
                currentChildForm.Height = HomeLayout.Height;
            }*/
            /*currentChildForm.Width = HomeLayout.Width;
            currentChildForm.Height = HomeLayout.Height;*/
            /*ContactBar.Location = new Point(0,  ContactBar.Width + MenuBar.Width);*/
        }
        private void HomeForm_Resize(object sender, EventArgs e)
        {
            resize();
        }

        

        private void Button_Back_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Back Click");
            /*if (previousChildForm != null)
                OpenChildForm(previousChildForm);
            else
                MessageBox.Show("No back");*/
        }
    }
}
