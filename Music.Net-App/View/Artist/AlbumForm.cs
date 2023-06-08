using Guna.UI2.WinForms;
using Music.Net_App.BLL;
using Music.Net_App.DAL;
using Music.Net_App.DTO;
using RestSharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music.Net_App.View.Artist
{
    public partial class AlbumForm : Form
    {
        public delegate void AlbumDelegate();
        public AlbumDelegate pd { get; set; }
        private UserDTO User;
        public delegate void SetUpMainFormDelegate();
        public SetUpMainFormDelegate su { get; set; }


        public delegate void OpenPlaylistSongForm(object sender, EventArgs e);
        public OpenPlaylistSongForm op { get; set; }
        //string fileNameFull;
        string destinationFilePath;
        System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();

        List<AlbumCombobox> albumComboboxes = new List<AlbumCombobox>();
        List<GenreCombobox> genreComboboxes = new List<GenreCombobox>();

        public AlbumForm(UserDTO User)
        {
            InitializeComponent();
            this.User = User;
            SetUpUserAlbum();
        }
        private void SetUpUserAlbum()
        {
            flowLayoutPanel1.Controls.OfType<FlowLayoutPanel>().ToList().ForEach(f => f.Dispose());
        
            foreach (AlbumDTO pl in AlbumBLL.Instance.GetAllAlbumOfArtist(User.UserId))
            {
                albumComboboxes.Add(new AlbumCombobox
                {
                    AlbumName = pl.AlbumName,
                    AlbumID = pl.AlbumID,
                });
                SetComboBoxGenre(User.UserId);
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
                    Text = pl.AlbumName,
                    Width = 200,
                    Margin = new Padding(0, 0, 0, 0)
                });
                flowLayoutPanel1.Controls.Add(p);
                loadAlbumComboBox(User.UserId);

      
            }
        }
        private void SetComboBoxGenre(int UserID)
        {
            foreach (var item in AlbumBLL.Instance.GetAllGenre())
            {
                genreComboboxes.Add(new GenreCombobox
                {
                    GenreID = item.GenreID,
                    GenreName = item.GenreName
                });
            }
            guna2ComboBoxGenre.Items.Clear();
            guna2ComboBoxGenre.Items.AddRange(genreComboboxes.ToArray());
            int size = guna2ComboBoxGenre.Items.Count;
            
            int index = 0;

            for (index = 0; index < size; index++)
            {
                if (((GenreCombobox)(guna2ComboBoxGenre.Items[index])).GenreID == AlbumBLL.Instance.getGenreIdOfArtist(UserID))
                {
                    guna2ComboBoxGenre.SelectedIndex = index;
                    break;
                }
            }
         
        
        }

        public void loadAlbumComboBox(int UserID)
        {
            albumComboboxes.Clear();
            foreach (var item in AlbumBLL.Instance.GetAllAlbumOfArtist(UserID))
            {
                albumComboboxes.Add(new AlbumCombobox
                {
                    AlbumName = item.AlbumName,
                    AlbumID = item.AlbumID,
                });
            }
            //guna2ComboBox1.SelectedIndex = -1;
           // guna2ComboBox1.DataSource = null;
           
            guna2ComboBox1.Items.Clear();
            guna2ComboBox1.Items.AddRange(albumComboboxes.ToArray());
        }
        private void Button_Add_Album_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text = "";
            guna2TextBox2.Text = "";
            guna2ComboBoxGenre.SelectedIndex = 0;
            guna2TextBox4.Text = "";
            panel1.Height = 800;
            Button_Delete.Visible = false;

       

            //pd();
        }


        private void guna2ButtonOK_Click(object sender, EventArgs e)
        {
            if(guna2TextBox1.Text == "" || guna2TextBox2.Text == "" || guna2TextBox4.Text == "")
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }
            AlbumDTO album = new AlbumDTO
            {
               AlbumName = guna2TextBox1.Text,
               PopularityScore = Convert.ToInt32(guna2TextBox2.Text),
               GenreID = Convert.ToInt32(((GenreCombobox)guna2ComboBoxGenre.SelectedItem).GenreID),
               Duration = Convert.ToInt32(guna2TextBox4.Text),
               ReleaseDate = DateTime.Now,
            };

      
        if(!Button_Delete.Visible) {
                if (AlbumBLL.Instance.AddAlbumOfArtist(album, User.UserId))
                {
                    MessageBox.Show("The Album has been successfully added.");
                }
                else
                {
                    MessageBox.Show("An error occurred while adding the Album.");
                }
            }
        else
            {
                album.AlbumID = (guna2ComboBox1.SelectedItem as AlbumCombobox).AlbumID;
                if(AlbumBLL.Instance.ModifyAlbum(album))
                {
                    MessageBox.Show("The Album has been successfully modified.");
                }
                else
                {
                    MessageBox.Show("An error occurred while modify the Album.");
                }
            }
 
            SetUpUserAlbum();
        


           
            panel1.Height = 100;
            
       
      
           
        }

        private void Button_Modify_Song_Click(object sender, EventArgs e)
        {
           
            panel1.Height = 800;
            guna2ComboBox1.Visible = true;

         /*   guna2ComboBox1.DataSource = albumComboboxes;
            guna2ComboBox1.DisplayMember = "AlbumName";
            guna2ComboBox1.ValueMember = "AlbumID";*/
            loadAlbumComboBox(User.UserId) ;

            Button_Delete.Visible = true;
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2ComboBox1.SelectedIndex == -1) return;
            AlbumDTO albumModify = AlbumBLL.Instance.GetAlbumById((guna2ComboBox1.SelectedItem as AlbumCombobox).AlbumID);
            guna2TextBox1.Text = albumModify.AlbumName;
            guna2TextBox2.Text = albumModify.PopularityScore.ToString();
            guna2ComboBoxGenre.SelectedIndex = albumModify.GenreID;
            guna2TextBox4.Text = albumModify.Duration.ToString();
}

           // MessageBox.Show(albumModify.AlbumName.ToString() + albumModify.AlbumName);
      

            //    SetUpUserAlbum();
        

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            if (guna2ComboBox1.SelectedItem != null)
            {
                if (AlbumBLL.Instance.RemoveAlbum((guna2ComboBox1.SelectedItem as AlbumCombobox).AlbumID))
                {
                    MessageBox.Show("Delete album successful");
                }
                else
                {
                    MessageBox.Show("Error occurs when delete album");
                }
            }
            loadAlbumComboBox(User.UserId);
        }

        private void guna2ButtonCancel_Click(object sender, EventArgs e)
        {
            panel1.Height = 100;
        }


    



















        /*        private void Button_OK_Click(object sender, EventArgs e)
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
                }*/
    }

}
