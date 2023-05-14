using Music.Net_App.DAL;
using Music.Net_App.DAL.Huy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Data.Entity;

namespace Music.Net_App.BLL
{
    internal class PlaylistBLL
    {
        EntitiesMusicNetApp db = new EntitiesMusicNetApp();

        //getAllPlaylist       
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

        //getPlaylistbyName     
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

        //GetAllPlaylistOfUser           
        public List<PlaylistListenerDTO> GetAllPlaylistOfListener(string listenerName)
        {
            List<PlaylistListenerDTO> result = new List<PlaylistListenerDTO>();

            var playlists = from p in db.Playlists
                            join l in db.Listeners on p.ListenerID equals l.ListenerID
                            where l.Name.Contains(listenerName)
                            select new { p.PlaylistName, l.Name };

            foreach (var item in playlists)
            {
                result.Add(new PlaylistListenerDTO
                {
                    PlaylistName = item.PlaylistName,
                    Name = item.Name
                });
            }

            if (result.Count == 0)
            {
                return null;
            }

            return result;
        }

        //GetAllSongOfPlaylist        
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

        //AddPlaylist   
        public bool AddPlaylist(PlaylistDTO playlistDTO)
        {
            try
            {
                Playlist playlist = new Playlist
                {
                    PlaylistID = playlistDTO.PlaylistID,
                    ListenerID = playlistDTO.ListenerID,
                    ArtistID = playlistDTO.ArtistID,
                    PlaylistTyped = playlistDTO.PlaylistTyped,
                    PlaylistName = playlistDTO.PlaylistName,
                    Descriptions = playlistDTO.Descriptions,
                    DateCreated = playlistDTO.DateCreated,
                    PopularityScore = playlistDTO.PopularityScore
                };
                db.Playlists.Add(playlist);
                db.SaveChanges();

                MessageBox.Show("The playlist has been successfully added.");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the playlist.");
                return false;
            }
        }

        //ModifyPlaylist
        public bool ModifyPlaylist(PlaylistDTO playlistDTO)
        {
            try
            {
                Playlist playlist = new Playlist
                {
                    PlaylistID = playlistDTO.PlaylistID,
                    ListenerID = playlistDTO.ListenerID,
                    ArtistID = playlistDTO.ArtistID,
                    PlaylistType = playlistDTO.PlaylistTyped,
                    PlaylistName = playlistDTO.PlaylistName,
                    Descriptions = playlistDTO.Descriptions,
                    DateCreated = playlistDTO.DateCreated,
                    PopularityScore = playlistDTO.PopularityScore
                };

                db.Entry(playlist).State = EntityState.Modified; //Giống ModifySong trong SongBLL
                db.SaveChanges();

                MessageBox.Show("The playlist has been edited successfully.");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while editing the playlist.");
                return false;
            }
        }

        //RemovePlaylist
        public bool RemovePlaylist(int playlistID)
        {
            try
            {
                Playlist playlist = new Playlist { PlaylistID = playlistID };
                db.Entry(playlist).State = EntityState.Deleted;  //
                db.SaveChanges();

                MessageBox.Show("The playlist has been successfully removed.");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while removing the playlist.");
                return false;
            }
        }

        // AddSongToPlaylist
        public bool AddSongToPlaylist(int playlistID, int songID)
        {
            try
            {
                var playlistSong = new PlaylistSong
                {
              
                    PlaylistID = playlistID,
                    SongID = songID,
                    DateAdded = DateTime.Now
                    
                };

                db.PlaylistSongs.Add(playlistSong);
                db.SaveChanges();

                MessageBox.Show("The song has been added to the playlist successfully.");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding a song to the playlist.");
                return false;
            }
        }
        //RemoveSongfromPlaylist
        public bool RemoveSongFromPlaylist(int playlistID, int songID)
        {
            try  
            {
                var playlistSong = db.PlaylistSongs.Where(ps => ps.PlaylistID == playlistID && ps.SongID == songID).FirstOrDefault();

                if (playlistSong != null)
                {
                    db.PlaylistSongs.Remove(playlistSong);
                    db.SaveChanges();
                    MessageBox.Show("The song has been removed from the playlist successfully.");
                    return true;
                }
                else
                {
                    MessageBox.Show("The song does not exist in the playlist.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while removing the song from the playlist.");
                return false;
            }
        }
    }
}
