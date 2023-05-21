using FontAwesome.Sharp;
using Guna.UI2.WinForms;
using Music.Net_App.BLL;
using Music.Net_App.DAL;
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
        public HomeForm(UserDTO User)
        {

            string directory = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug\", "");
            InitializeComponent();
            IntroVideo.URL = directory + @"\Assets\Videos\video.mp4";
            IntroVideo.settings.setMode("loop", true);
            IntroVideo.settings.mute = true;

            /*        C: \Users\Lenovo\source\repos\Music\MusicApp\Music.Net - App\Assets\Musics\y2mate.com - DVRST  CLOSE EYES.mp3
            */
            /*if (theme == "light" && theme != null)
            {
                MessageBox.Show("Night");
                TopMixes.BackColor = Color.White;
                RecentPlayed.BackColor = Color.White;
                foreach (Control c in this.Controls)
                {
                    c.BackColor = Color.White;
                }
            }*/

                foreach (UserHistoryDTO c in UserBLL.Instance.GetHistory(User.UserId))
                {
                    Guna2Panel gp = new Guna2Panel
                    {
                        BackColor = Color.DimGray,
                        Size = new Size(182, 152)
                    };
                    Label l = new Label
                    {
                        Text = c.ItemName + "\n" + c.TimeStamp,
                        ForeColor = Color.White,
                    };
                    gp.Controls.Add(l);
                    RecentPlayed.Controls.Add(gp);
                }
            
        }
        private void resize()
        {
            /*MenuBar.Height = this.Height;
            ContactBar.Height = this.Height;*/
            /*HomeLayout.Height = this.Height;
            HomeLayout.Width = this.Width*/;
            //MessageBox.Show(this.Width + this.Height + "");
            HomeLayout.Size = new Size(this.Width, this.Height);

            iconButton4.Width = HomeLayout.Width-30;
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
