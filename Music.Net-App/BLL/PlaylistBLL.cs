using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
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

        public PlaylistDTO GetPlaylistById(int playlistID)
        {
            try
            {
                PlaylistDTO pd = new PlaylistDTO();
                var playlist = (from p in db.Playlists
                                where p.PlaylistID == playlistID
                                select p).First();
                if (playlist != null)
                {
                    pd = new PlaylistDTO
                    {
                        PlaylistId = playlist.PlaylistID,
                        PlaylistName = playlist.PlaylistName,
                        PlaylistType = playlist.PlaylistTyped,
                        PopularityScore = Convert.ToInt32(playlist.PopularityScore),
                        DateCreated = Convert.ToDateTime(playlist.DateCreated),
                        Description = playlist.Descriptions
                    };
                }

                return pd;
            }catch(Exception)
            {
                return null;
            }
            

            
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
        public List<SongDTO> GetAllSongOfPlaylist(int playlistID)
        {
            List<SongDTO> result = new List<SongDTO>();
            var songs = (from s in db.Songs
                         join ps in db.PlaylistSongs on s.SongID equals ps.SongID
                         join p in db.Playlists on ps.PlaylistID equals p.PlaylistID
                         where p.PlaylistID == playlistID
                         select new { s.SongName, p.PlaylistName })
                         .ToList();

            if(songs.Any())
            {
                foreach (var item in songs)
                {
                    result.Add(new SongDTO
                    {
                        //PlaylistName = item.PlaylistName,
                        SongName = item.SongName
                    });
                }
            }

            return result;
        }

        //AddSongToPlaylist   but 7
        public int GetMaxPlaylistSongsID()
        {
            var maxColumnValue = (from item in db.PlaylistSongs
                                  select item.PlayListSongID).Max();

            return maxColumnValue;
        }
        public bool AddSongToPlaylist(int playlistID, int songID)
        {

            var playlist = (from p in db.Playlists
                           where p.PlaylistID == playlistID
                           select p).First();
            var song  = (from s in db.Songs
                        where s.SongID == songID
                        select s).First();
            if (playlist == null || song == null)
            {
                return false;
            }

            var existingSong = (from ps in db.PlaylistSongs
                               where ps.SongID == playlistID && ps.SongID == songID
                               select ps).First();
            if (existingSong != null) return true;
            

            try
            {
                var newPlaylistSong = new PlaylistSong
                {
                    PlayListSongID = GetMaxPlaylistSongsID(),
                    PlaylistID = playlist.PlaylistID,
                    SongID = song.SongID
                };
                db.PlaylistSongs.Add(newPlaylistSong);
                db.SaveChanges();
                
                return true;
            }
            catch
            {
                
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
