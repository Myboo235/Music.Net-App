using Music.Net_App.DAL;
using Music.Net_App.DAL.Huy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;

namespace Music.Net_App.BLL
{
    internal class PlaylistBLL
    {
        EntitiesMusicNetApp db = new EntitiesMusicNetApp();
        //getAllPlaylist        but3
        public List<PlaylistListenerDTO> GetAllPlaylists()
        {
            List<PlaylistListenerDTO> playlists = new List<PlaylistListenerDTO>();
            var query = from playlist in db.Playlists
                        join listener in db.Listeners on playlist.ListenerID equals listener.ListenerID
                        select new PlaylistListenerDTO
                        {
                            PlaylistName = playlist.PlaylistName,
                            Name = listener.Name
                        };

            foreach (var item in query)
            {
                playlists.Add(item);
            }

            return playlists;
        }


        //getPlaylistbyName      but4
        public List<PlaylistListenerDTO> GetPlaylistByName(string name)
        {
            List<PlaylistListenerDTO> playlists = new List<PlaylistListenerDTO>();
            var query = from playlist in db.Playlists
                        join listener in db.Listeners on playlist.ListenerID equals listener.ListenerID
                        where playlist.PlaylistName.Contains(name)
                        select new PlaylistListenerDTO
                        {
                            PlaylistName = playlist.PlaylistName,
                            Name = listener.Name
                        };

            foreach (var item in query)
            {
                playlists.Add(item);
            }

            return playlists;
        }

        //GetAllPlaylistOfUser           but5
        public List<PlaylistListenerDTO> GetAllPlaylistOfListener(string listenerName)
        {
            List<PlaylistListenerDTO> result = new List<PlaylistListenerDTO>();

            var playlists = db.Playlists
                .Join(db.Listeners, p => p.ListenerID, l => l.ListenerID, (p, l) => new { Playlist = p, Listener = l })
                .Where(pl => pl.Listener.Name.Contains(listenerName))
                .Select(pl => new { pl.Playlist.PlaylistName, pl.Listener.Name })
                .ToList();

            foreach (var item in playlists)
            {
                result.Add(new PlaylistListenerDTO
                {
                    PlaylistName = item.PlaylistName,
                    Name = item.Name 
                });
            }

            if (playlists.Count == 0)
            {
                return null;
            }

            return result;
        }


        //GetAllSongOfPlaylist         but6
        public List<PlaylistSongDTO> GetAllSongOfPlaylist(string playlistName)
        {
            List<PlaylistSongDTO> result = new List<PlaylistSongDTO>();
            var songs = (from s in db.Songs
                         join ps in db.PlaylistSongs on s.SongID equals ps.SongID
                         join p in db.Playlists on ps.PlaylistID equals p.PlaylistID
                         where  p.PlaylistName.Contains(playlistName)
                         select new { s.SongName, p.PlaylistName })
                         .ToList();
            foreach (var item in songs)
            {
                result.Add(new PlaylistSongDTO
                {
                    PlaylistName = item.PlaylistName,
                    SongName = item.SongName
                });
            }

            if (songs.Count == 0)
            {
                return null;
            }

            return result;
        }

        //AddPlaylist   but8
        public bool AddPlaylist(string playlistName, string listenerName)
        {
            // Kiểm tra xem người nghe nhạc có tồn tại không
            var listener = db.Listeners.FirstOrDefault(l => l.Name == listenerName);
            if (listener == null)
            {
                MessageBox.Show("Người nghe nhạc không tồn tại.");
                return false;
            }

            // Kiểm tra xem danh sách phát đã tồn tại chưa
            var existingPlaylist = db.Playlists.FirstOrDefault(p => p.PlaylistName == playlistName);
            if (existingPlaylist != null)
            {
                MessageBox.Show("Danh sách phát đã tồn tại.");
                return false;
            }

            try
            {
                // Tạo danh sách phát mới và thêm vào cơ sở dữ liệu
                var newPlaylist = new Playlist
                {
                    PlaylistName = playlistName,
                    ListenerID = listener.ListenerID
                };
                db.Playlists.Add(newPlaylist);
                db.SaveChanges();
                MessageBox.Show("Danh sách phát đã được tạo thành công.");
                return true;
            }
            catch
            {
                MessageBox.Show("Lỗi khi tạo danh sách phát.");
                return false;
            }
        }
        // ModifyPlaylist
        public bool ModifyPlaylist(string playlistName, string newPlaylistName)
        {
            // Kiểm tra xem danh sách phát có tồn tại không
            var playlist = db.Playlists.FirstOrDefault(p => p.PlaylistName == playlistName);
            if (playlist == null)
            {
                MessageBox.Show("Playlist không tồn tại.");
                return false;
            }

            try
            {
                // Chỉnh sửa tên danh sách phát
                playlist.PlaylistName = newPlaylistName;
                db.SaveChanges();
                MessageBox.Show("Playlist đã chỉnh sửa thành công.");
                return true;
            }
            catch
            {
                MessageBox.Show("Lỗi khi chỉnh sửa Playlist.");
                return false;
            }
        }
        //AddSongToPlaylist   but 7
        public bool AddSongToPlaylist(string playlistName, string songName)
        {
            // Kiểm tra xem playlist có tồn tại không
            var playlist = db.Playlists.FirstOrDefault(p => p.PlaylistName == playlistName);
            if (playlist == null)
            {
                MessageBox.Show("playlist không tồn tại.");
                return false;
            }

            // Kiểm tra xem bài hát có tồn tại không
            var song = db.Songs.FirstOrDefault(s => s.SongName == songName);
            if (song == null)
            {
                MessageBox.Show("Bài hát không tồn tại.");
                return false;
            }

            // Kiểm tra xem bài hát đã tồn tại trong palylist chưa
            var existingSong = db.PlaylistSongs.FirstOrDefault(ps => ps.PlaylistID == playlist.PlaylistID && ps.SongID == song.SongID);
            if (existingSong != null)
            {
                MessageBox.Show("Bài hát đã tồn tại trong playlist.");
                return false;
            }

            try
            {
                // Thêm bài hát vào playlist
                var newPlaylistSong = new PlaylistSong
                {
                    PlaylistID = playlist.PlaylistID,   //ID của pl mà bài hát sẽ được thêm vào
                    SongID = song.SongID                //ID của bài hát được thêm vào pl
                };
                db.PlaylistSongs.Add(newPlaylistSong);
                db.SaveChanges();
                MessageBox.Show("Bài hát được thêm thành công.");
                return true;
            }
            catch
            {
                MessageBox.Show("Lỗi khi thêm bài hát vào playlist.");
                return false;
            }
        }

        //RemoveSongfromPlaylist
        // RemoveSongfromPlaylist
        public bool RemoveSongfromPlaylist(string playlistName, string songName)
        {
            // Kiểm tra xem playlist có tồn tại không
            var playlist = db.Playlists.FirstOrDefault(p => p.PlaylistName == playlistName);
            if (playlist == null)
            {
                MessageBox.Show("Playlist không tồn tại.");
                return false;
            }

            // Kiểm tra xem bài hát có tồn tại không
            var song = db.Songs.FirstOrDefault(s => s.SongName == songName);
            if (song == null)
            {
                MessageBox.Show("Bài hát không tồn tại.");
                return false;
            }

            try
            {
                // Kiểm tra xem bài hát có tồn tại trong playlist không
                var playlistSong = db.PlaylistSongs.FirstOrDefault(ps => ps.PlaylistID == playlist.PlaylistID && ps.SongID == song.SongID);
                if (playlistSong == null)
                {
                    MessageBox.Show("Bài hát không tồn tại trong playlist.");
                    return false;
                }

                // Xóa bài hát khỏi playlist
                db.PlaylistSongs.Remove(playlistSong);
                db.SaveChanges();
                MessageBox.Show("Bài hát đã được xóa khỏi playlist.");
                return true;
            }
            catch
            {
                MessageBox.Show("Lỗi khi xóa bài hát khỏi playlist.");
                return false;
            }
        }

    }
}
