using Guna.UI2.WinForms;
using Music.Net_App.BLL;
using Music.Net_App.DAL;
using Music.Net_App.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music.Net_App.View.Listener
{
    public partial class ProfileForm : Form
    {
        string directory = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug\", "");
        UserDTO User = null;
        UserBLL UserBLL = new UserBLL();
        PlaylistBLL PlaylistBLL = new PlaylistBLL();
        public ProfileForm(UserDTO user)
        {
            InitializeComponent();
            guna2CirclePictureBox1.Image = resizeImage(Image.FromFile(directory + @"\Assets\Images\Profile-picture.png"),
                new Size(guna2CirclePictureBox1.Width, guna2CirclePictureBox1.Height)); 
            guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;

            User = user;

            SetUpUserProfile();
        }

        private void SetUpUserProfile()
        {

            label2.Text = User.Name;
            label2.Width = guna2CustomGradientPanel1.Width;   

            foreach (Playlist3DTO c in PlaylistBLL.GetAllPlaylistOfListener(User.Name))
            {
                Guna2Panel gp = new Guna2Panel
                {
                    BackColor = Color.AntiqueWhite,
                };
                Label l = new Label
                {
                    Width = gp.Width,
                    Height = gp.Height,
                    Text = c.PlaylistName + "\n" + c.ListenerName,
                };
                gp.Controls.Add(l);
                flowLayoutPanel1.Controls.Add(gp);
            }
        }
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

    }
}
