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
        List<AlbumCombobox> AlbumComboboxes = new List<AlbumCombobox>();
        List<GenreCombobox> genreComboboxes = new List<GenreCombobox>();
        private List<Guna2Panel> ln = new List<Guna2Panel>();

        string selectedSongNameAdd = "";
        string selectedSongNameRemove = "";
        int selectedSongIDAdd = 0;
        int selectedSongIDRemove = 0;
        int selectedAlbumID = 0;
        public AlbumForm(UserDTO User)
        {
            InitializeComponent();
            this.User = User;
            SetUpUserAlbum();
            SetUpAlbumComboBox(User.UserId);
            Button_AddToAlbum.Visible = false;
          
        }
        private void SetUpUserAlbum()
        {
            flowLayoutPanel1.Controls.OfType<FlowLayoutPanel>().ToList().ForEach(f => f.Dispose());
            foreach (AlbumDTO pl in AlbumBLL.Instance.GetAllAlbumOfArtist(User.UserId))
            {
               
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

        public void SetUpAlbumComboBox(int UserID)
        {
            AlbumComboboxes.Clear();
            foreach (var item in AlbumBLL.Instance.GetAllAlbumOfArtist(UserID))
            {
                AlbumComboboxes.Add(new AlbumCombobox
                {
                    AlbumName = item.AlbumName,
                    AlbumID = item.AlbumID,
                });
            }
          
           // guna2ComboBox1.DataSource = null;
           
            guna2ComboBox1.Items.Clear();
            guna2ComboBox1.Items.AddRange(AlbumComboboxes.ToArray());
            guna2ComboBox1.SelectedIndex = 0;
        }
        private void Button_Add_Album_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text = "";
            guna2TextBox2.Text = "";
            guna2ComboBoxGenre.SelectedIndex = 0;
            guna2TextBox4.Text = "";
            panel1.Height = 800;
            guna2ComboBox1.Visible = false ;
            label2.Visible = false;
            label3.Visible = false;
            label8.Visible = false;
            flowLayoutPanel2.Visible = false;
            flowLayoutPanel3.Visible = false;

            Buttom_RemoveFromAlbum.Visible = false;
            Button_Delete.Visible = false;
            Button_AddToAlbum.Visible = false;


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

        private void Button_Modify_Album_Click(object sender, EventArgs e)
        {
           
            panel1.Height = 800;
            guna2ComboBox1.Visible = true;
            SetUpAlbumComboBox(User.UserId) ;
            DisplayAllSongOfArtist();
            DisplayAllSongOfAlbum();

            label2.Visible = true;
            label3.Visible = true;
            label8.Visible = true;
            flowLayoutPanel2.Visible = true;
            flowLayoutPanel3.Visible = true;

            Buttom_RemoveFromAlbum.Visible = true;
            Button_Delete.Visible = true;
            Button_AddToAlbum.Visible = true;

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2ComboBox1.SelectedIndex < 0) return;
            AlbumDTO albumModify = AlbumBLL.Instance.GetAlbumById((guna2ComboBox1.SelectedItem as AlbumCombobox).AlbumID);
            guna2TextBox1.Text = albumModify.AlbumName;
            guna2TextBox2.Text = albumModify.PopularityScore.ToString();
            guna2ComboBoxGenre.SelectedIndex = albumModify.GenreID;
            guna2TextBox4.Text = albumModify.Duration.ToString();
            selectedAlbumID = (guna2ComboBox1.SelectedItem as AlbumCombobox).AlbumID;
            DisplayAllSongOfAlbum();

        }
        
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
            SetUpAlbumComboBox(User.UserId);
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
                    Width = flowLayoutPanel2.Width - 10,
                                    
                };
                Label Songname = new Label
                {
                    Name = item.SongID+"",
                    Text = item.SongName,
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    Height = 50,
                    Width = p.Width - 10,
                    
                };
                Songname.Click += new EventHandler(SongClickedAdd);
                p.Controls.Add(Songname);
                p.BackColor = Color.Transparent;
                p.FillColor = Color.Transparent;
                p.BorderColor = Color.White;
                p.BorderRadius = 20;
                p.CustomBorderColor = Color.White;
                p.CustomBorderThickness = new Padding(0, 1, 0, 0);
                ln.Add(p);
                p.Height = 40;

                flowLayoutPanel2.Controls.Add(p);
            }

     
        }


        public void DisplayAllSongOfAlbum()
        {
            flowLayoutPanel3.Controls.Clear();
            foreach (SongDTO item in AlbumBLL.Instance.GetAllSongOfAlbum(selectedAlbumID))
            {
                Guna2Panel p = new Guna2Panel
                {
                    Width = flowLayoutPanel2.Width - 10,

                };
                Label Songname = new Label
                {
                    Name = item.SongID + "",
                    Text = item.SongName,
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    Height = 50,
                    Width = p.Width - 10,

                };

                Songname.Click += new EventHandler(SongClickedRemove);

                p.Controls.Add(Songname);
                p.BackColor = Color.Transparent;
                p.FillColor = Color.Transparent;
                p.BorderColor = Color.White;
                p.BorderRadius = 20;
                p.CustomBorderColor = Color.White;
                p.CustomBorderThickness = new Padding(0, 1, 0, 0);
                ln.Add(p);
                p.Height = 40;

                flowLayoutPanel3.Controls.Add(p);
            }

        }


        

        private void SongClickedAdd(object sender, EventArgs e)
        {
            selectedSongNameAdd = (sender as Label).Text;
            label8.Text = "You're choosing: "+ selectedSongNameAdd;
            selectedSongIDAdd = Convert.ToInt32((sender as Label).Name);
        }

        private void Button_AddToAlbum_Click(object sender, EventArgs e)
        {
            
            if (selectedSongNameAdd.Length == 0) return;
            if (AlbumBLL.Instance.AddSongToAlbum((guna2ComboBox1.SelectedItem as AlbumCombobox).AlbumID, selectedSongIDAdd))
            {
                MessageBox.Show("Add to " + album.AlbumName + " successfully");
            }
            else
            {
                MessageBox.Show("An error occurred while adding song to album or it's already in " + album.AlbumName);
            }

            selectedSongNameAdd = "";
            DisplayAllSongOfAlbum();
        }

        private void SongClickedRemove(object sender, EventArgs e)
        {
            selectedSongNameRemove = (sender as Label).Text;
            selectedSongIDRemove = Convert.ToInt32((sender as Label).Name);
            label3.Text = "You're choosing: " + selectedSongNameRemove;
        }
        private void Buttom_RemoveFromAlbum_Click(object sender, EventArgs e)
        {
            if (selectedSongNameRemove.Length == 0) return;
            MessageBox.Show(selectedSongNameRemove + " " + selectedSongIDRemove);
            if (AlbumBLL.Instance.RemoveSongFromAlbum(selectedAlbumID, selectedSongIDRemove))
            {
                MessageBox.Show("Remove from " + album.AlbumName + " successfully");
            }
            else
            {
                MessageBox.Show("An error occurred while removing song to album");
            }
            DisplayAllSongOfAlbum();
            selectedSongNameRemove = "";
        }
    }

}
