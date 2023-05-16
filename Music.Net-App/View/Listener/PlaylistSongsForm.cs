using Music.Net_App.BLL;
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
        PlaylistBLL playlistBLL = new PlaylistBLL();
        PlaylistDTO playlist = new PlaylistDTO();
        public PlaylistSongsForm(int playlistID)
        {
            InitializeComponent();
            playlist = playlistBLL.GetPlaylistById(playlistID);

            SetUpPlaylistSong();
        }

        public void SetUpPlaylistSong()
        {
            label2.Text = playlist.PlaylistName;
            foreach(SongDTO s in playlistBLL.GetAllSongOfPlaylist(playlist.PlaylistId))
            {
                panel1.Controls.Add(
                new Label{
                    Text = s.SongName,
                    Width = panel1.Width/2
                });
            }
        }

    }
}
