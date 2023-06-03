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
    public partial class PlaylistSongsForm : Form
    {
        public delegate void PlaylistSongDelegate();
        public PlaylistSongDelegate psd { get; set; }
        
        PlaylistDTO playlist = new PlaylistDTO();
        private List<Guna2Panel> pn = new List<Guna2Panel>();
        private List<Guna2Panel> ln = new List<Guna2Panel>();
        private List<Guna2TextBox> t = new List<Guna2TextBox>();
        public PlaylistSongsForm(int playlistID)
        {
            InitializeComponent();
            playlist = PlaylistBLL.Instance.GetPlaylistById(playlistID);
            SetUpPlaylistSong();
        }

        private void Button_Remove_Song_Click(object sender, EventArgs e)
        {
            int songID = Convert.ToInt32((sender as Guna2Button).Name);
            //MessageBox.Show((sender as Guna2Button).Name);
            if (PlaylistBLL.Instance.RemoveSongFromPlaylist(playlist.PlaylistId, songID))
            {
                MessageBox.Show("Remove from " + playlist.PlaylistName + " successfully");
                int thisformheight = this.Height;
                int songinplaylistheight = flowLayoutPanel1.Height;
                SetUpPlaylistSong();
                flowLayoutPanel1.Height = songinplaylistheight - 150;
                this.Height = thisformheight - 80;
            }
            else
                MessageBox.Show("An error occurred while remove song from playlist");

        }
        public void SetUpPlaylistSong()
        {
            label2.Text = playlist.PlaylistName;
            label3.Text = playlist.Description;
            label3.Width = flowLayoutPanel4.Width;
            flowLayoutPanel1.Controls.Clear();
            foreach (SongDTO s in PlaylistBLL.Instance.GetAllSongOfPlaylist(playlist.PlaylistId))
            {
                Guna2Panel p = new Guna2Panel();
                FlowLayoutPanel f = new FlowLayoutPanel
                {
                    FlowDirection = FlowDirection.TopDown,
                    Width = p.Width
                };
                FlowLayoutPanel fb = new FlowLayoutPanel
                {
                    FlowDirection = FlowDirection.BottomUp,
                    Size = new Size(262, 81),
                    Dock = DockStyle.Right,
                };
                Label SongName = new Label
                {
                    Text = s.SongName,
                    //Text = a.AlbumName,
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    Padding = new Padding(20, 10, 0, 0),
                    //Dock = DockStyle.Top,
                    Height = 40,
                    Width = f.Width,
                };
                Label Artist = new Label
                {
                    Text = s.ArtistName,
                    //Text = a.AlbumName,
                    ForeColor = Color.DimGray,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    //Margin = new Padding(0, 20, 0, 0),
                    Padding = new Padding(20, 0, 0, 0),
                    Height = 40,
                    Width = f.Width,
                    //Dock = DockStyle.Left,

                };
                //SongName.Click += new EventHandler(Label_Click);
                Guna2Button b = new Guna2Button
                {
                    Name = s.SongID.ToString(),
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
                p.Width = flowLayoutPanel1.Width-30;
                p.BackColor = Color.Transparent;
                p.FillColor = Color.Transparent;
                p.BorderColor = Color.White;
                //p.BorderRadius = 20;
                p.CustomBorderColor = Color.White;
                p.CustomBorderThickness = new Padding(0, 1, 0, 0);
                f.Controls.Add(SongName);
                f.Controls.Add(Artist);
                fb.Controls.Add(b);
                p.Controls.Add(f);
                p.Controls.Add(fb);

                /*string directory = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug\", "");
                t.Image = Image.FromFile(directory + @"\Assets\Images\Song-icon.jpg");

                t.SizeMode = PictureBoxSizeMode.CenterImage;
                t.Anchor = AnchorStyles.None;*/
                flowLayoutPanel1.Height += 80;
                flowLayoutPanel1.Controls.Add(p);
                this.Height += 80;
            }
        }

        private void Button_Delete_Playlist_Click(object sender, EventArgs e)
        {
            MessageBox.Show(playlist.PlaylistId + "");
            if (PlaylistBLL.Instance.RemovePlaylist(playlist.PlaylistId))
                MessageBox.Show("Delete success");
            else
                MessageBox.Show("Error occurs when delete playlist");
            Close();
            psd();
        }
        private void Button_Add_Song_Click(object sender, EventArgs e)
        {
            int songID = Convert.ToInt32((sender as Guna2Button).Name);
            //MessageBox.Show((sender as Guna2Button).Name);
            if (PlaylistBLL.Instance.AddSongToPlaylist(playlist.PlaylistId, songID))
            {
                MessageBox.Show("Add to " + playlist.PlaylistName + " successfully");
                int thisformheight = this.Height;
                int songinplaylistheight = flowLayoutPanel1.Height;
                SetUpPlaylistSong();
                flowLayoutPanel1.Height = songinplaylistheight + 80;
                this.Height = thisformheight + 80;
                psd();
            }   
            else
                MessageBox.Show("An error occurred while adding song to playlist or it's already in "+playlist.PlaylistName);
            
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            foreach (SongDTO s in SongBLL.Instance.GetSongByName(guna2TextBox1.Text))
            //foreach (AlbumDTO a in album.GetAllAlbum())
            {
                Guna2Panel p = new Guna2Panel();
                FlowLayoutPanel f = new FlowLayoutPanel
                {
                    FlowDirection = FlowDirection.TopDown,
                    Width = p.Width
                };
                FlowLayoutPanel fb = new FlowLayoutPanel
                {
                    FlowDirection = FlowDirection.BottomUp,
                    Size = new Size(262, 81),
                    Dock = DockStyle.Right,
                };
                Label SongName = new Label
                {
                    Text = s.SongName,
                    //Text = a.AlbumName,
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    Padding = new Padding(20, 10, 0, 0),
                    //Dock = DockStyle.Top,
                    Height = 40,
                    Width = f.Width,
                };
                Label Artist = new Label
                {
                    Text = s.ArtistName,
                    //Text = a.AlbumName,
                    ForeColor = Color.DimGray,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    //Margin = new Padding(0, 20, 0, 0),
                    Padding = new Padding(20, 0, 0, 0),
                    Height = 40,
                    Width = f.Width,
                    //Dock = DockStyle.Left,

                };
                //SongName.Click += new EventHandler(Label_Click);
                Guna2Button b = new Guna2Button
                {
                    Name = s.SongID.ToString(),
                    Text = "Add to Playlist",
                    Font = new Font("Segoe UI", 9),
                    Size = new Size(206, 52),
                    FillColor = Color.Transparent,
                    BorderColor = Color.White,
                    BorderRadius = 20,
                    BorderThickness = 2,

                };
                b.Click += new EventHandler(Button_Add_Song_Click);
                pn.Add(p);
                p.Height = 80;
                p.Width = flowLayoutPanel2.Width - 30;
                p.BackColor = Color.Transparent;
                p.FillColor = Color.Transparent;
                p.BorderColor = Color.White;
                //p.BorderRadius = 20;
                p.CustomBorderColor = Color.White;
                p.CustomBorderThickness = new Padding(0, 1, 0, 0);
                f.Controls.Add(SongName);
                f.Controls.Add(Artist);
                fb.Controls.Add(b);
                p.Controls.Add(f);
                p.Controls.Add(fb);

                /*string directory = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug\", "");
                t.Image = Image.FromFile(directory + @"\Assets\Images\Song-icon.jpg");

                t.SizeMode = PictureBoxSizeMode.CenterImage;
                t.Anchor = AnchorStyles.None;*/

                flowLayoutPanel2.Controls.Add(p);
            }
        }

        private void PlaylistSongsForm_Resize(object sender, EventArgs e)
        {
            flowLayoutPanel1.Width = flowLayoutPanel3.Width;
            flowLayoutPanel2.Width = flowLayoutPanel3.Width+20;
            foreach(Guna2Panel g in ln)
            {
                
                g.Width = flowLayoutPanel1.Width;
            }
        }

        private void Button_Collapse_Click(object sender, EventArgs e)
        {
            if(Button_Collapse.Text == "Collapse")
            {
                flowLayoutPanel1.Height = 130;
                flowLayoutPanel1.AutoScroll = true;
                Button_Collapse.Text = "Load more";
            }
            else
            {
                SetUpPlaylistSong();
                flowLayoutPanel1.AutoScroll = false;
                Button_Collapse.Text = "Collapse";
            }
             
        }

        private void Button_Modify_Click(object sender, EventArgs e)
        {
            if(Button_Modify.IconChar == FontAwesome.Sharp.IconChar.Pen)
            {
                flowLayoutPanel4.Controls.Clear();
                Button_Modify.Text = "OK";
                Button_Modify.IconChar = FontAwesome.Sharp.IconChar.None;
                Button_Modify.TextImageRelation = TextImageRelation.Overlay;
                Guna2TextBox tb = new Guna2TextBox
                {
                    Text = playlist.PlaylistName,
                    BackColor = Color.Transparent,
                    FillColor = Color.DimGray,
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 48, FontStyle.Bold),
                    Height = 106,
                    Width = flowLayoutPanel4.Width - 20,
                };
                Guna2TextBox tbd = new Guna2TextBox
                {
                    Text = playlist.Description,
                    BackColor = Color.Transparent,
                    FillColor = Color.DimGray,
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 11, FontStyle.Bold),
                    Height = 23,
                    Width = flowLayoutPanel4.Width - 20,
                };
                t.Clear();
                t.Add(tb);
                t.Add(tbd);
                flowLayoutPanel4.Controls.Add(tb);
                flowLayoutPanel4.Controls.Add(tbd);
            }
            else if(Button_Modify.IconChar == FontAwesome.Sharp.IconChar.None)
            {
                playlist.PlaylistName = t[0].Text;
                playlist.Description = t[1].Text;
                if (PlaylistBLL.Instance.ModifyPlaylist(playlist))
                {
                    MessageBox.Show("Modify successfully");
                    label2.Text = playlist.PlaylistName;
                    label3.Text = playlist.Description;
                    label3.Width = flowLayoutPanel4.Width;
                    CancelModify();
                }
                else
                {
                    MessageBox.Show("A error occur when modify");
                }
            }
        }

        void CancelModify()
        {
            flowLayoutPanel4.Controls.Clear();
            Button_Modify.Text = "Modify";
            Button_Modify.IconChar = FontAwesome.Sharp.IconChar.Pen;
            Button_Modify.TextImageRelation = TextImageRelation.ImageBeforeText;
            Label l = new Label
            {
                Text = playlist.PlaylistName,
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 48, FontStyle.Bold),
                Height = 106,
                Width = flowLayoutPanel4.Width - 20,
            };
            Label d = new Label
            {
                Text = playlist.Description,
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                //Height = 106,
                Width = flowLayoutPanel4.Width - 20,
            };
            flowLayoutPanel4.Controls.Add(l);
            flowLayoutPanel4.Controls.Add(d);
        }
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            CancelModify();
        }
    }
}
