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
            panel1.Height = flowLayoutPanel1.Height - 9;

            foreach (PlaylistDTO c in PlaylistBLL.Instance.GetAllPlaylistOfListener(User.UserId))
            {
                Guna2Panel gp = new Guna2Panel
                {
                    BackColor = Color.Transparent,
                    FillColor = Color.FromArgb(25,20,20),
                    BorderRadius = 20,
                    Size = new Size(182, 250),
                };
                FlowLayoutPanel f = new FlowLayoutPanel
                {
                    Height = gp.Height,
                    Width = gp.Width,
                    BackColor = Color.Transparent,
                    RightToLeft = RightToLeft.Yes,
                };
                Guna2PictureBox pb = new Guna2PictureBox
                {
                    Size = new Size(172, 156),
                    SizeMode = PictureBoxSizeMode.AutoSize,
                    BorderRadius = 20
                };
                Label l = new Label
                {
                    Width = gp.Width,
                    Height = 100,
                    Text = c.PlaylistName + "\n" +"playlist\n"+ User.Name,
                    ForeColor = Color.White
                };
                f.Controls.Add(pb);
                f.Controls.Add(l);
                gp.Controls.Add(f);
                flowLayoutPanel1.Controls.Add(gp);
            }
            if(User.TypeUser == "Artist")
            {
                foreach (AlbumDTO c in AlbumBLL.Instance.GetAllAlbumOfArtist(User.UserId))
                {
                    Guna2Panel gp = new Guna2Panel
                    {
                        BackColor = Color.Transparent,
                        FillColor = Color.FromArgb(25, 20, 20),
                        BorderRadius = 20,
                        Size = new Size(182, 250),
                    };
                    FlowLayoutPanel f = new FlowLayoutPanel
                    {
                        Height = gp.Height,
                        Width = gp.Width,
                        BackColor = Color.Transparent,
                        RightToLeft = RightToLeft.Yes,
                    };
                    Guna2PictureBox pb = new Guna2PictureBox
                    {
                        Size = new Size(172, 156),
                        SizeMode = PictureBoxSizeMode.AutoSize,
                        BorderRadius = 20,
                        Image = resizeImage(Image.FromFile(directory + @"\Assets\Images\muzira-banner.png"), new Size(150, 150))
                    };
                    Label l = new Label
                    {
                        Width = gp.Width,
                        Height = 100,
                        Text = c.AlbumName + "\n" + "album\n" + User.Name,
                        ForeColor = Color.White
                    };
                    f.Controls.Add(pb);
                    f.Controls.Add(l);
                    gp.Controls.Add(f);
                    flowLayoutPanel1.Controls.Add(gp);
                }
                foreach (SongDTO c in SongBLL.Instance.GetAllSongOfArtist(User.UserId))
                {
                    Guna2Panel gp = new Guna2Panel
                    {
                        BackColor = Color.Transparent,
                        FillColor = Color.FromArgb(25, 20, 20),
                        BorderRadius = 20,
                        Size = new Size(182, 250),
                    };
                    FlowLayoutPanel f = new FlowLayoutPanel
                    {
                        Height = gp.Height,
                        Width = gp.Width,
                        BackColor = Color.Transparent,
                        RightToLeft = RightToLeft.Yes,
                    };
                    Guna2PictureBox pb = new Guna2PictureBox
                    {
                        Size = new Size(172, 156),
                        SizeMode = PictureBoxSizeMode.AutoSize,
                        BorderRadius = 20
                    };
                    Label l = new Label
                    {
                        Width = gp.Width,
                        Height = 100,
                        Text = c.SongName + "\n" + "song\n" + User.Name,
                        ForeColor = Color.White
                    };
                    f.Controls.Add(pb);
                    f.Controls.Add(l);
                    gp.Controls.Add(f);
                    flowLayoutPanel1.Controls.Add(gp);
                }
            }
        }
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

    }
}
