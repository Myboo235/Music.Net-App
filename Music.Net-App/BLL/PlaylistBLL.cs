using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Music.Net_App.DAL;
using Music.Net_App.DTO;

namespace Music.Net_App.BLL
{
    internal class PlaylistBLL
    {
        EntitiesMusicNetApp db = new EntitiesMusicNetApp();


        public List<Playlist1DTO> GetAllPlaylists()
        {
            List<Playlist1DTO> playlists = new List<Playlist1DTO>();
            EntitiesMusicNetApp db = new EntitiesMusicNetApp();
            var query = from playlist in db.Playlists
                        join listener in db.Listeners on playlist.ListenerID equals listener.ListenerID
                        select new Playlist1DTO
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
        public List<Playlist2DTO> GetPlaylistbyName(string name)
        {
            List<Playlist2DTO> re = new List<Playlist2DTO>();

            var playlists = db.Playlists
                .Where(p => p.PlaylistName.Contains(name))
                .Select(p => new { p.PlaylistName })
                .ToList();
            foreach (var item in playlists)
            {
                re.Add(
                    new Playlist2DTO
                    {
                        PlaylistName = item.PlaylistName
                    }
                );
            }
            if (playlists.Count == 0 || !playlists.Any(p => p.PlaylistName.Contains(name)))
            {
                return null;
            }
            return re;
        }
        //GetAllPlaylistOfUser
        public List<PlaylistDTO> GetAllPlaylistOfListener(int listenerID)
        {
            List<PlaylistDTO> result = new List<PlaylistDTO>();

            var playlists = from p in db.Playlists
                            where p.ListenerID == listenerID
                            select p;

            if (playlists.Any())
            {
                foreach (var item in playlists.ToList())
                {
                    result.Add(new PlaylistDTO
                    {
                        PlaylistName = item.PlaylistName,
                        PlaylistType = item.PlaylistTyped,
                        PlaylistId = item.PlaylistID,
                        DateCreated = Convert.ToDateTime(item.DateCreated),
                        Description = item.Descriptions,
                        PopularityScore = Convert.ToInt32(item.PopularityScore)
                    });
                }

                return result;
            }
            
            return null;
        }


        //GetAllSongOfPlaylist
        public List<SongDTO> GetAllSongOfPlaylist(string playlistName)
        {
            List<SongDTO> result = new List<SongDTO>();
            var songs = (from s in db.Songs
                         join ps in db.PlaylistSongs on s.SongID equals ps.SongID
                         join p in db.Playlists on ps.PlaylistID equals p.PlaylistID
                         where p.PlaylistName.Contains(playlistName)
                         select new { s.SongName, p.PlaylistName })
                         .ToList();
            foreach (var item in songs)
            {
                result.Add(new SongDTO
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

        //AddSongToPlaylist   but 7
        public bool AddSongToPlaylist(string playlistName, string songName)
        {
            // Kiểm tra xem danh sách phát có tồn tại không
            var playlist = db.Playlists.FirstOrDefault(p => p.PlaylistName == playlistName);
            if (playlist == null)
            {
                Console.WriteLine("Danh sách phát không tồn tại.");
                return false;
            }

            // Kiểm tra xem bài hát có tồn tại không
            var song = db.Songs.FirstOrDefault(s => s.SongName == songName);
            if (song == null)
            {
                Console.WriteLine("Bài hát không tồn tại.");
                return false;
            }

            // Kiểm tra xem bài hát đã tồn tại trong danh sách phát chưa
            var existingSong = db.PlaylistSongs.FirstOrDefault(ps => ps.PlaylistID == playlist.PlaylistID && ps.SongID == song.SongID);
            if (existingSong != null)
            {
                Console.WriteLine("Bài hát đã tồn tại trong danh sách phát.");
                return false;
            }

            try
            {
                // Thêm bài hát vào danh sách phát
                var newPlaylistSong = new PlaylistSong
                {
                    PlaylistID = playlist.PlaylistID,
                    SongID = song.SongID
                };
                db.PlaylistSongs.Add(newPlaylistSong);
                db.SaveChanges();
                Console.WriteLine("Bài hát đã được thêm vào danh sách phát thành công.");
                return true;
            }
            catch
            {
                Console.WriteLine("Lỗi khi thêm bài hát vào danh sách phát.");
                return false;
            }
        }


        public int GetPlaylistCount()
        {
            return db.Playlists.Count();
        }
        //AddPlaylist   but8
        public bool AddPlaylist(PlaylistDTO playlistDTO, int userID)
        {
            try
            {
                Playlist playlist = new Playlist
                {
                    PlaylistID = GetPlaylistCount() + 1,
                    ListenerID = userID,
                    ArtistID = 1,
                    PlaylistTyped = playlistDTO.PlaylistType,
                    PlaylistName = playlistDTO.PlaylistName,
                    Descriptions = playlistDTO.Description,
                    DateCreated = playlistDTO.DateCreated,
                    PopularityScore = playlistDTO.PopularityScore
                };
                db.Playlists.Add(playlist);
                db.SaveChanges();

                //MessageBox.Show("The playlist has been successfully added.");
                return true;
            }
            catch (Exception)
            {
                //MessageBox.Show("An error occurred while adding the playlist.");
                return false;
            }
        }

        //ModifyPlaylist
        // ModifyPlaylist
        public bool ModifyPlaylist(string playlistName, string newPlaylistName)
        {
            // Kiểm tra xem danh sách phát có tồn tại không
            var playlist = db.Playlists.FirstOrDefault(p => p.PlaylistName == playlistName);
            if (playlist == null)
            {
                Console.WriteLine("Playlist không tồn tại.");
                return false;
            }

            try
            {
                // Chỉnh sửa tên danh sách phát
                playlist.PlaylistName = newPlaylistName;
                db.SaveChanges();
                Console.WriteLine("Playlist đã chỉnh sửa thành công.");
                return true;
            }
            catch
            {
                Console.WriteLine("Lỗi khi chỉnh sửa Playlist.");
                return false;
            }
        }


    }
}
