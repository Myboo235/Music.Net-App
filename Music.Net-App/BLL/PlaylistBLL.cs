using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        private static PlaylistBLL _Instance;
        public static PlaylistBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new PlaylistBLL();
                }
                return _Instance;
            }
            private set { }
        }
        /*public List<PlaylistDTO> GetAllPlaylists()
        {
            List<PlaylistDTO> playlists = new List<PlaylistDTO>();
            EntitiesMusicNetApp db = new EntitiesMusicNetApp();
            var query = from playlist in db.Playlists
                        join listener in db.Listeners on playlist.ListenerID equals listener.ListenerID
                        select new PlaylistDTO
                        {
                            PlaylistName = playlist.PlaylistName,
                            Name = listener.Name
                        };

            foreach (var item in query)
            {
                playlists.Add(item);
            }

            return playlists;
        }*/

        public PlaylistDTO GetPlaylistById(int playlistID)
        {
            PlaylistDTO pd = new PlaylistDTO();
            try
            {
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
                return pd;
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

                
            }

            return result;
        }

        public List<PlaylistDTO> GetAllPlaylistOfArtist(int artistID)
        {
            List<PlaylistDTO> result = new List<PlaylistDTO>();

            var playlists = from p in db.Playlists
                            where p.ArtistID == artistID
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


            }

            return result;
        }


        public List<PlaylistDTO> GetAllPlaylist()
        {
            List<PlaylistDTO> result = new List<PlaylistDTO>();
        

            var playlists = from p in db.Playlists
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


            }

          

            return result;
        }
        //GetAllSongOfPlaylist
        public List<SongDTO> GetAllSongOfPlaylist(int playlistID)
        {
            List<SongDTO> result = new List<SongDTO>();
            var songs = (from s in db.Songs
                         join ps in db.PlaylistSongs on s.SongID equals ps.SongID
                         join p in db.Playlists on ps.PlaylistID equals p.PlaylistID
                         join a in db.Artists on s.ArtistID equals a.ArtistID
                         where p.PlaylistID == playlistID
                         select new { s.SongID, s.SongName, s.DateCreated, s.Duration, a.ArtistID, a.Name })
                         .ToList();

            if(songs.Any())
            {
                foreach (var item in songs.ToList())
                {
                    result.Add(new SongDTO
                    {
                        SongID = item.SongID,
                        SongName = item.SongName,
                        ArtistName = item.Name,
                        ArtistID = item.ArtistID,
                        Duration = Convert.ToInt32(item.Duration),
                        DateCreated = Convert.ToDateTime(item.DateCreated),
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
                           select p).FirstOrDefault();
            var song  = (from s in db.Songs
                        where s.SongID == songID
                        select s).FirstOrDefault();
            if (playlist == null || song == null)
            {
                return false;
            }

            var existingSong = (from ps in db.PlaylistSongs
                               where ps.PlaylistID == playlistID && ps.SongID == songID
                               select ps).FirstOrDefault();
            if (existingSong != null) return false;
            

            try
            {
                var newPlaylistSong = new PlaylistSong
                {
                    PlayListSongID = GetMaxPlaylistSongsID() + 1,
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

        public int GetMaxPlaylistID()
        {
            var maxColumnValue = (from item in db.Playlists
                                  select item.PlaylistID).Max();

            return maxColumnValue;
        }
        public bool AddPlaylistOfListener(PlaylistDTO playlistDTO, int userID)
        {
            try
            {
                Playlist playlist = new Playlist
                {
                    PlaylistID = GetMaxPlaylistID() + 1,
                    ListenerID = userID,
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

        public bool AddPlaylistOfArtist(PlaylistDTO playlistDTO, int userID)
        {
            try
            {
                Playlist playlist = new Playlist
                {
                    PlaylistID = GetMaxPlaylistID() + 1,
                    ArtistID = userID,
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
        public bool RemovePlaylist(int playlistID)
        {
            try
            {
                var playlist = (from p in db.Playlists
                                where p.PlaylistID == playlistID
                                select p).FirstOrDefault();

                if (playlist != null)
                {
                    db.Playlists.Remove(playlist);
                    db.SaveChanges();

                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

       /* public bool RemovePlaylist(int playlistID)
        {
            try
            {
                var playlist = db.Playlists.FirstOrDefault(p => p.PlaylistID == playlistID);

                if (playlist != null)
                {
                    db.Playlists.Remove(playlist);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }*/

        public bool RemoveSongFromPlaylist(int playlistID, int songID)
        {
            try
            {
                //var playlistSong = db.PlaylistSongs.Where(ps => ps.PlaylistID == playlistID && ps.SongID == songID).FirstOrDefault();
                var playlistSong = (from ps in db.PlaylistSongs
                                   where ps.PlaylistID == playlistID && ps.SongID == songID
                                   select ps).FirstOrDefault();
                if (playlistSong != null)
                {
                    db.PlaylistSongs.Remove(playlistSong);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool ModifyPlaylist(PlaylistDTO playlistDTO)
        {
            try
            {
                var playlist = (from p in db.Playlists
                               where p.PlaylistID == playlistDTO.PlaylistId
                               select p).FirstOrDefault();
                if (playlist != null)
                {
                    playlist.PlaylistTyped = playlistDTO.PlaylistType;
                    playlist.PlaylistName = playlistDTO.PlaylistName;
                    playlist.Descriptions = playlistDTO.Description;
                    playlist.DateCreated = playlistDTO.DateCreated;
                    playlist.PopularityScore = playlistDTO.PopularityScore;

                    db.SaveChanges();
                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
