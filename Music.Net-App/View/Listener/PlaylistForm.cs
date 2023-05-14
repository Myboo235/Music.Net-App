using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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

        string directory = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug", "");
        private List<FlowLayoutPanel> tb = new List<FlowLayoutPanel>();
        private UserDTO User;
        PlaylistBLL p = new PlaylistBLL();
        public PlaylistForm(UserDTO User)
        {
            InitializeComponent();
            LikedSong_Panel.BackgroundImage = SetImageOpacity(Image.FromFile(directory + @"\Assets\Images\Heart.jpg"), 0.75F);

            /*flowLayoutPanel5.BackgroundImage = ;*/
            //flowLayoutPanel5.BackgroundImageLayout = ImageLayout.Center;
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
            flowLayoutPanel3.Controls.OfType<FlowLayoutPanel>().ToList().ForEach(f => f.Dispose());
            foreach (PlaylistDTO pl in p.GetAllPlaylistOfListener(User.UserId))
            {
                FlowLayoutPanel p = new FlowLayoutPanel();
                p.Size = new Size(200, 400);
                p.FlowDirection = FlowDirection.TopDown;
                p.BackColor = SystemColors.ActiveCaption;
                p.Controls.Add(new PictureBox
                {
                    BackgroundImage = resizeImage(Image.FromFile(directory + @"\Assets\Images\muzira-banner.png"), new Size(200, 200)),
                    Size = new Size(200, 200),
                    BackColor = Color.White,
                    Margin = new Padding(0, 0, 0, 0)
                });
                p.Controls.Add(new Label
                {
                    Text = pl.PlaylistName,
                    Width = 200,
                    Margin = new Padding(0, 0, 0, 0)
                });
                tb.Add(p);
                flowLayoutPanel3.Controls.Add(p);
            }
        }
        private void PlaylistForm_Resize(object sender, EventArgs e)
        {
            flowLayoutPanel3.Width = this.Width-9;
            flowLayoutPanel3.Height = this.Height - 10;
            panel1.Width = flowLayoutPanel3.Width - 30;
        }

        private void Button_Add_Playlist_Click(object sender, EventArgs e)
        {
            panel1.Height = 800;
            //Button_Add_Playlist.Enabled = false;
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

            if (p.AddPlaylist(playlist, User.UserId))
            {
                MessageBox.Show("The playlist has been successfully added.");
            }
            else
            {
                MessageBox.Show("An error occurred while adding the playlist.");
            }
            panel1.Height = 100;
            SetUpUserPlaylist();

        }
    }
}
