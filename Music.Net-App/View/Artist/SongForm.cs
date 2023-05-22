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
                flowLayoutPanel1.Controls.Add(p);
            }
        }

        private void Button_Choose_File_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string sourceFilePath = openFileDialog.FileName;
                    string fileName = Path.GetFileNameWithoutExtension(sourceFilePath);
                    MessageBox.Show("Choose "+fileName + " successs");
                    label5.Text = fileName;
                }
            }
        }

        private void Button_Add_Song_Click(object sender, EventArgs e)
        {
            panel1.Height = 800;

        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            panel1.Height = 100;
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string sourceFilePath = openFileDialog.FileName;

                    string destinationFolderPath = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug\", "") + @"\Assets\Musics";
                    string fileName = Path.GetFileName(sourceFilePath);
                    string destinationFilePath = Path.Combine(destinationFolderPath, fileName);
                    if (File.Exists(destinationFilePath))
                    {
                        DialogResult overwriteResult = MessageBox.Show("The file already exists in the destination folder. Do you want to overwrite it?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (overwriteResult == DialogResult.No)
                        {
                            return;
                        }
                    }

                    try
                    {

                        File.Copy(sourceFilePath, destinationFilePath, true);
                        MessageBox.Show("Get File successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            SongDTO s = new SongDTO
            {
                SongName = label5.Text,
                ArtistID = User.UserId,
                DateCreated = DateTime.Now,
                Duration = Convert.ToInt32(guna2TextBox2.Text),
            };
            if(SongBLL.Instance.AddSong(s, User.UserId))
            {

                MessageBox.Show("The playlist has been successfully added.");
            }
            else
            {
                MessageBox.Show("An error occurred while adding the playlist.");
            }
            panel1.Height = 100;
        }
    }


}
