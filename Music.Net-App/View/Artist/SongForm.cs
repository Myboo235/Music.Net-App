using Microsoft.Win32;
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
        string sourceFilePath;
        string fileName;
        string destinationFolderPath = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug\", "") + @"\Assets\Musics";
        //string fileNameFull;
        string destinationFilePath;
        System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();

        List<SongCombobox> songComboboxes = new List<SongCombobox>();
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
                songComboboxes.Add(new SongCombobox
                {
                    SongName = pl.SongName,
                    SongID = pl.SongID,
                });
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
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string sourceFilePath = openFileDialog.FileName;
                string fileName = Path.GetFileNameWithoutExtension(sourceFilePath);
                MessageBox.Show("Choose " + fileName + " successs");
                label5.Text = fileName;
                guna2TextBox1.Text = fileName;
            }

        }

        private void Button_Add_Song_Click(object sender, EventArgs e)
        {
            Button_Delete_Song.Height = 800;
            guna2ComboBox1.Visible = false;
            //label2.Visible = true;
            Button_Delete.Visible = false;
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            Button_Delete_Song.Height = 100;
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            if (!guna2ComboBox1.Visible)
            {
                sourceFilePath = openFileDialog.FileName;
                destinationFolderPath = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug\", "") + @"\Assets\Musics";
                fileName = Path.GetFileName(sourceFilePath);
                destinationFilePath = Path.Combine(destinationFolderPath, fileName);
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
                SongDTO s = new SongDTO
                {
                    SongName = label5.Text,
                    ArtistID = User.UserId,
                    DateCreated = DateTime.Now,
                    Duration = Convert.ToInt32(guna2TextBox2.Text),
                };
                if (SongBLL.Instance.AddSong(s, User.UserId))
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
                if (guna2ComboBox1.SelectedItem != null)
                {
                    sourceFilePath = openFileDialog.FileName;
                    destinationFolderPath = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug\", "") + @"\Assets\Musics";
                    fileName = Path.GetFileName(sourceFilePath);
                    destinationFilePath = Path.Combine(destinationFolderPath, fileName);
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
                    SongDTO s = new SongDTO
                    {
                        SongID = (guna2ComboBox1.SelectedItem as SongCombobox).SongID,
                        SongName = (guna2ComboBox1.SelectedItem as SongCombobox).SongName,
                        ArtistID = User.UserId,
                        DateCreated = DateTime.Now,
                        Duration = Convert.ToInt32(guna2TextBox2.Text),
                    };
                    if (SongBLL.Instance.ModifySong(s))
                    {

                        MessageBox.Show("The song has been successfully modified.");
                    }
                    else
                    {
                        MessageBox.Show("An error occurred while modify the song.");
                    }
                }

            }
            
            Button_Delete_Song.Height = 100;
        }

        private void Button_Modify_Song_Click(object sender, EventArgs e)
        {
            Button_Delete_Song.Height = 800;
            guna2ComboBox1.Visible = true;

            guna2ComboBox1.DataSource = songComboboxes;
            guna2ComboBox1.DisplayMember = "SongName";
            guna2ComboBox1.ValueMember = "SongID";
            
            Button_Delete.Visible = true;
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SongDTO songModify = SongBLL.Instance.GetSongByID((guna2ComboBox1.SelectedItem as SongCombobox).SongID);
            guna2TextBox1.Text = songModify.SongName;
            guna2TextBox2.Text = songModify.Duration.ToString();
            MessageBox.Show(songModify.Duration.ToString() + songModify.SongID);
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            if (guna2ComboBox1.SelectedItem != null)
            {
                if (SongBLL.Instance.RemoveSong((guna2ComboBox1.SelectedItem as SongCombobox).SongID))
                {
                    MessageBox.Show("Delete song successful");
                }
                else
                {
                    MessageBox.Show("Error occurs when delete song");
                }
            }
        }
    }


}
