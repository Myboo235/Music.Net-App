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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Music.Net_App.View.Artist
{
    public partial class AlbumForm : Form
    {
        public delegate void AlbumDelegate();
        public AlbumDelegate ad { get; set; }
        private UserDTO User;
        AlbumDTO album = new AlbumDTO();
        
        public delegate void SetUpMainFormDelegate();
        public SetUpMainFormDelegate su { get; set; }


        public delegate void OpenPlaylistSongForm(object sender, EventArgs e);
        public OpenPlaylistSongForm op { get; set; }
        //string fileNameFull;
        string destinationFilePath;
        System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();

        List<AlbumCombobox> albumComboboxes = new List<AlbumCombobox>();
        List<GenreCombobox> genreComboboxes = new List<GenreCombobox>();
        private List<Guna2Panel> ln = new List<Guna2Panel>();

        public AlbumForm(UserDTO User)
        {
            InitializeComponent();
            this.User = User;
            SetUpUserAlbum();
            DisplayAllSongOfAlbum();
           guna2ButtonAdd.Visible = false;
          
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
            //setAlbumSongOfArtist(User.UserId);
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
          
           // guna2ComboBox1.DataSource = null;
           
            guna2ComboBox1.Items.Clear();
            guna2ComboBox1.Items.AddRange(albumComboboxes.ToArray());
            guna2ComboBox1.SelectedIndex = 0;
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
            loadAlbumComboBox(User.UserId) ;
            DisplayAllSongOfArtist();
            Button_Delete.Visible = true;
            guna2ButtonAdd.Visible = true;

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


    

        public void DisplayAllSongOfArtist()
        {
            flowLayoutPanel2.Controls.Clear();
            foreach (SongDTO item in SongBLL.Instance.GetAllSongOfArtist(User.UserId))
            {
                Guna2Panel p = new Guna2Panel {
                    Width = 300,
                    Height = 300
                                    
                };
                FlowLayoutPanel f = new FlowLayoutPanel
                {
                    FlowDirection = FlowDirection.TopDown,
                    Width = p.Width,
                };
                Label Songname = new Label
                {
                    Text = item.SongName,
                    //Text = a.AlbumName,
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    Padding = new Padding(20, 10, 0, 0),
                    //Dock = DockStyle.Top,
                    Height = 40,
                    Width = 250,
                };
                Songname.Click += new EventHandler(songClicked);



                f.Controls.Add(Songname);

                p.BackColor = Color.Transparent;
                p.FillColor = Color.Transparent;
                p.BorderColor = Color.White;
                p.BorderRadius = 20;
                p.CustomBorderColor = Color.White;
                p.CustomBorderThickness = new Padding(0, 1, 0, 0);
                ln.Add(p);
                p.Height = 40;
                p.Controls.Add(f);
                flowLayoutPanel2.Controls.Add(p);
 
               
            }

     
        }


        public void DisplayAllSongOfAlbum()
        {
            flowLayoutPanel3.Controls.Clear();
            foreach (SongDTO item in AlbumBLL.Instance.GetAllSongOfAlbum((guna2ComboBox1.SelectedItem as AlbumCombobox).AlbumID))
            {
                Guna2Panel p = new Guna2Panel
                {
                    Width = 300,
                    Height = 300

                };
                FlowLayoutPanel f = new FlowLayoutPanel
                {
                    FlowDirection = FlowDirection.TopDown,
                    Width = p.Width,
                };
                FlowLayoutPanel fb = new FlowLayoutPanel
                {
                    FlowDirection = FlowDirection.BottomUp,
                    Size = new Size(100, 30),
                    Dock = DockStyle.Right,
                };
                Label SongName = new Label
                {
                    Text = item.SongName,
                    //Text = a.AlbumName,
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    Padding = new Padding(20, 10, 0, 0),
                    //Dock = DockStyle.Top,
                    Height = 40,
                    Width = 250,
                };




                Guna2Button b = new Guna2Button
                {
                    Name = item.SongID.ToString(),
                    Text = "Remove from playlist",
                    Font = new Font("Segoe UI", 9),
                    Size = new Size(206, 52),
                    FillColor = Color.Transparent,
                    BorderColor = Color.White,
                    BorderRadius = 20,
                    BorderThickness = 2,

                };
                b.Click += new EventHandler(Button_Remove_Song_Click);
                ln.Add(p);
                p.Height = 80;
                p.Width = flowLayoutPanel1.Width - 30;
                p.BackColor = Color.Transparent;
                p.FillColor = Color.Transparent;
                p.BorderColor = Color.White;
                p.BorderRadius = 20;
                p.CustomBorderColor = Color.White;
                p.CustomBorderThickness = new Padding(0, 1, 0, 0);
                f.Controls.Add(SongName);
                fb.Controls.Add(b);
                p.Controls.Add(f);
                p.Controls.Add(fb);

                flowLayoutPanel3.Controls.Add(p);
            }


        }


        private void Button_Remove_Song_Click(object sender, EventArgs e)
        {
            int songID = Convert.ToInt32((sender as Guna2Button).Name);
            if (AlbumBLL.Instance.RemoveSongFromAlbum(Convert.ToInt32((guna2ComboBox1.SelectedItem as AlbumDTO).AlbumID),songID))
            {
                MessageBox.Show("Remove from " + album.AlbumName + " successfully");
                int thisformheight = this.Height;
                int songinplaylistheight = flowLayoutPanel3.Height;
               // SetAlbumSong();
                flowLayoutPanel3.Height = songinplaylistheight - 100;
                this.Height = thisformheight - 40;
            }
            else
                MessageBox.Show("An error occurred while remove song from playlist");

        }

        string selectedSongName = "";

        private void songClicked(object sender, EventArgs e)
        {
            selectedSongName = (sender as Label).Text;
            label3.Text = "You're choosing: "+selectedSongName;
       
        }

        private void guna2ButtonAdd_Click(object sender, EventArgs e)
        {
            
            if (selectedSongName.Length == 0) return;

            //find songid by artistid and songname
            MessageBox.Show("SONGNAME : <" + selectedSongName + "> ; ID: " + User.UserId);
            int songID = SongBLL.Instance.GetSongByIDAndArtistID(selectedSongName.Trim(), User.UserId);
            SongDTO songAdd = SongBLL.Instance.GetSongByID(songID);
            MessageBox.Show("SongID: " + songID.ToString());
            MessageBox.Show((guna2ComboBox1.SelectedItem as AlbumCombobox).AlbumID.ToString() + "- name : " + (guna2ComboBox1.SelectedItem as AlbumCombobox).AlbumName.ToString());
            if (AlbumBLL.Instance.AddSongToAlbum((guna2ComboBox1.SelectedItem as AlbumCombobox).AlbumID, songID))
            {
                MessageBox.Show("Add to " + album.AlbumName + " successfully");
            }
            else
                MessageBox.Show("An error occurred while adding song to album or it's already in " + album.AlbumName);  

            selectedSongName = "";

        }


       

       
    }

}
