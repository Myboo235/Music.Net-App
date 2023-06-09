﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Music.Net_App.BLL;
using Music.Net_App.DAL;
using Music.Net_App.DTO;

namespace Music.Net_App.View
{

    public partial class PlaylistForm : Form
    {
        public delegate void PlaylistDelegate();
        public PlaylistDelegate pd { get; set; }

        public delegate void SetUpMainFormDelegate();
        public SetUpMainFormDelegate su { get; set; }


        public delegate void OpenPlaylistSongForm (object sender, EventArgs e);
        public OpenPlaylistSongForm op { get; set; }

        string directory = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug", "");
        private List<FlowLayoutPanel> tb = new List<FlowLayoutPanel>();
        private UserDTO User;
        public PlaylistForm(UserDTO User)
        {
            InitializeComponent();
            LikedSong_Panel.BackgroundImage = SetImageOpacity(Image.FromFile(directory + @"\Assets\Images\Heart.jpg"), 0.75F);
            this.User = User;
            SetUpUserPlaylist();
        }
        public Image SetImageOpacity(Image image, float opacity)
        {
            Bitmap bmp = new Bitmap(image.Width, image.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = opacity;
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default,
                                                  ColorAdjustType.Bitmap);
                g.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height),
                                   0, 0, image.Width, image.Height,
                                   GraphicsUnit.Pixel, attributes);
            }
            return bmp;
        }
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
        private void Playlist_Panel_MouseHover(object sender, EventArgs e)
        {
            LikedSong_Panel.BackgroundImage = SetImageOpacity(Image.FromFile(directory + @"\Assets\Images\Heart.jpg"), 0.25F);
        }

        private void Playlist_Panel_MouseLeave(object sender, EventArgs e)
        {
            LikedSong_Panel.BackgroundImage = SetImageOpacity(Image.FromFile(directory + @"\Assets\Images\Heart.jpg"), 0.75F);
        }

        private void SetUpUserPlaylist()
        {
            flowLayoutPanel1.Controls.OfType<FlowLayoutPanel>().ToList().ForEach(f => f.Dispose());
            List<PlaylistDTO> playlistofuser = new List<PlaylistDTO>();
            if (User.TypeUser == "Listener")
            {
                playlistofuser = PlaylistBLL.Instance.GetAllPlaylistOfListener(User.UserId);
            }
            else
            {
                playlistofuser = PlaylistBLL.Instance.GetAllPlaylistOfArtist(User.UserId);
            }
            foreach (PlaylistDTO pl in playlistofuser)
            {
                FlowLayoutPanel p = new FlowLayoutPanel();
                p.Name = pl.PlaylistId.ToString();
                p.Height = 374;
                p.Width = 240;
                //p.Size = new Size(240, 600);
                p.FlowDirection = FlowDirection.TopDown;
                p.BackColor = SystemColors.ActiveCaption; 
                p.AutoSize = false;
                p.Controls.Add(new PictureBox
                {
                    BackgroundImage = resizeImage(Image.FromFile(directory + @"\Assets\Images\muzira-banner.png"), new Size(240, 300)),
                    Size = new Size(240, 180),
                    BackColor = Color.White,
                    Margin = new Padding(0, 0, 0, 0)
                });
                p.Controls.Add(new Label
                {
                    Text = pl.PlaylistName,
                    //Size = new Size(240, 200),
                    Margin = new Padding(0, 0, 0, 0)
                });
                
                tb.Add(p);
                flowLayoutPanel1.Controls.Add(p);
            }
        }
        private void PlaylistForm_Resize(object sender, EventArgs e)
        {
            flowLayoutPanel3.Width = this.Width-9;
            flowLayoutPanel1.Width = flowLayoutPanel3.Width - 9;
            flowLayoutPanel3.Height = this.Height - 10;
           
            panel1.Width = flowLayoutPanel3.Width - 30;
            /*foreach (FlowLayoutPanel f in tb)
            {
                f.Size = new Size(240, 374);
            }*/
        }

        private void Button_Add_Playlist_Click(object sender, EventArgs e)
        {
            panel1.Height = 800;
            pd();
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            panel1.Height = 100;
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            PlaylistDTO playlist = new PlaylistDTO
            {
                PlaylistName = guna2TextBox1.Text,
                PlaylistType = guna2TextBox2.Text,
                Description = guna2TextBox3.Text,
                DateCreated = DateTime.Now,
            };
            if(User.TypeUser == "Listener")
            {
                if (PlaylistBLL.Instance.AddPlaylistOfListener(playlist, User.UserId))
                {
                    MessageBox.Show("The playlist has been successfully added.");
                }
                else
                {
                    MessageBox.Show("An error occurred while adding the playlist.");
                }
            }
            else
            {
                if (PlaylistBLL.Instance.AddPlaylistOfArtist(playlist, User.UserId))
                {
                    MessageBox.Show("The playlist has been successfully added.");
                }
                else
                {
                    MessageBox.Show("An error occurred while adding the playlist.");
                }
            }
            
            panel1.Height = 100;
            SetUpUserPlaylist();
            pd();
            /*foreach (FlowLayoutPanel f in tb)
            {
                MessageBox.Show(f.Size + "");
            }*/
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel 
            {
                
            };
        }
    }
}
