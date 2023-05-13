using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Music.Net_App.BLL;
using Music.Net_App.DAL;

namespace Music.Net_App.DAL.Huy
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SongBLL songBLL = new SongBLL();
            List<SongArtistDTO> songs = songBLL.GetAllSongs();
            dataGridView1.DataSource = songs;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SongBLL songBLL = new SongBLL();
            string searchValue = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Vui lòng nhập bài hát");
                return;
            }

            List<SongArtistDTO> songDTOs = songBLL.GetSongByName(searchValue);

            if (songDTOs.Count == 0)
            {
                MessageBox.Show("Không tìm thấy bài hát");
                return;
            }

            dataGridView1.DataSource = songDTOs;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                PlaylistBLL playlistBLL = new PlaylistBLL();
                List<PlaylistListenerDTO> playlists = playlistBLL.GetAllPlaylists();
                dataGridView1.DataSource = playlists;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text.Trim();
            PlaylistBLL playlistBLL = new PlaylistBLL();
            List<PlaylistListenerDTO> query = playlistBLL.GetPlaylistByName(searchValue);
            dataGridView1.DataSource = query;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string listenername = textBox1.Text.Trim();
            PlaylistBLL playlistBLL = new PlaylistBLL();

            List<PlaylistListenerDTO> playlists = playlistBLL.GetAllPlaylistOfListener(listenername);

            if (playlists == null || playlists.Count == 0)
            {
                MessageBox.Show("Không tìm thấy danh sách Playlist!");
                return;
            }

            dataGridView1.DataSource = playlists;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string playlistName = textBox1.Text.Trim();
            PlaylistBLL playlistBLL = new PlaylistBLL();

            // Lấy danh sách bài hát trong playlist
            List<PlaylistSongDTO> songs = playlistBLL.GetAllSongOfPlaylist(playlistName);

            // Hiển thị danh sách bài hát trên dataGridView1
            if (songs == null || songs.Count == 0)
            {
                MessageBox.Show("Không tìm thấy bài hát trong playlist!");
            }
            else
            {
                dataGridView1.DataSource = songs;
            }
        }
    }
}

