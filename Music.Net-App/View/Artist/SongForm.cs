using Music.Net_App.BLL;
using Music.Net_App.DAL;
using Music.Net_App.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music.Net_App.View.Artist
{
    public partial class SongForm : Form
    {
        private UserDTO User;
        public SongForm(UserDTO User)
        {
            InitializeComponent();
            this.User = User;
            SetUpUserSong();
        }
        private void SetUpUserSong()
        {
            flowLayoutPanel1.Controls.OfType<FlowLayoutPanel>().ToList().ForEach(f => f.Dispose());
            foreach (SongDTO pl in SongBLL.Instance.GetAllSongOfArtist(User.UserId))
            {
                FlowLayoutPanel p = new FlowLayoutPanel();
                p.Size = new Size(240, 374);
                Margin = new Padding(10, 10, 10, 10);
                p.FlowDirection = FlowDirection.TopDown;
                p.BackColor = Color.AntiqueWhite;
                p.Controls.Add(new PictureBox
                {
                    //BackgroundImage = resizeImage(Image.FromFile(directory + @"\Assets\Images\muzira-banner.png"), new Size(240, 200)),
                    Size = new Size(240, 200),
                    BackColor = Color.White,
                    Margin = new Padding(0, 0, 0, 0)
                });
                p.Controls.Add(new Label
                {
                    Text = pl.SongName,
                    Width = 200,
                    Margin = new Padding(0, 0, 0, 0)
                });
                //tb.Add(p);
                flowLayoutPanel1.Controls.Add(p);
            }
        }

        private void Button_Choose_File_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
        }

        private void Button_Add_Song_Click(object sender, EventArgs e)
        {
            panel1.Height = 800;


        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            panel1.Height = 100;
        }
    }


}
