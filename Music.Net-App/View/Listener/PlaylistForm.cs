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
        UserBLL b = new UserBLL();
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
        public PlaylistForm(UserDTO User)
        {
            InitializeComponent();
            LikedSong_Panel.BackgroundImage = SetImageOpacity(Image.FromFile(directory + @"\Assets\Images\Heart.jpg"), 0.75F);
            /*pictureBox1.BackgroundImage = SetImageOpacity(Image.FromFile(directory + @"\Assets\Images\Heart.jpg"), 0.75F);
            pictureBox2.BackgroundImage = SetImageOpacity(Image.FromFile(directory + @"\Assets\Images\Heart.jpg"), 0.75F);
            pictureBox3.BackgroundImage = SetImageOpacity(Image.FromFile(directory + @"\Assets\Images\Heart.jpg"), 0.75F);*/

            /*flowLayoutPanel5.BackgroundImage = ;*/
            //flowLayoutPanel5.BackgroundImageLayout = ImageLayout.Center;

            
                this.User = User;
            
            

        }

        private void Playlist_Panel_MouseHover(object sender, EventArgs e)
        {
            LikedSong_Panel.BackgroundImage = SetImageOpacity(Image.FromFile(directory + @"\Assets\Images\Heart.jpg"), 0.25F);
        }

        private void Playlist_Panel_MouseLeave(object sender, EventArgs e)
        {
            LikedSong_Panel.BackgroundImage = SetImageOpacity(Image.FromFile(directory + @"\Assets\Images\Heart.jpg"), 0.75F);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (User != null)
            {
                MessageBox.Show(User.Name);
            }
            else
            {
                MessageBox.Show("Guest");
                return;
            }
            
            foreach(Music.Net_App.DAL.Playlist pl in b.getUserPlaylist(User.UserId))
            {
                FlowLayoutPanel p = new FlowLayoutPanel();
                p.Size = new Size(224, 450);
                p.FlowDirection = FlowDirection.TopDown;
                p.BackColor = SystemColors.ActiveCaption;
                p.Controls.Add(new PictureBox
                {
                    BackgroundImage = resizeImage(Image.FromFile(directory + @"\Assets\Images\muzira-banner.png"), new Size(224, 300)),
                    Size = new Size(224, 300),
                    BackColor = Color.White,
                    Margin = new Padding(0,0,0,0)
                });
                p.Controls.Add(new Label
                {
                    Text= pl.PlaylistName,
                    Size = new Size(224, 100),
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
        }
    }
}
