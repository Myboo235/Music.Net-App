/*using Music.Net_App.DAL.Huy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Net_App.BLL
{
    internal class PlaylistBLL
    {
        MusicNetAppEntities1 db = new MusicNetAppEntities1();

        //getAllPlaylist        but3
        public List<Playlist1DTO> GetAllPlaylists()
        {
            List<Playlist1DTO> playlistDTOs = new List<Playlist1DTO>();
            List<Playlist> playlists = db.Playlists.ToList();
            foreach (Playlist playlist in playlists)
            {
                playlistDTOs.Add(new Playlist1DTO
                {
                    PlaylistID = playlist.PlaylistID,
                    ListenerID =(int) playlist.ListenerID,
                    //ArtistID = (int)playlist.ArtistID,
                    //PlaylistTyped = (string)playlist.PlaylistTyped,
                    PlaylistName = playlist.PlaylistName,
                    //Descriptions = playlist.Descriptions,
                    //DateCreated = (DateTime)playlist.DateCreated,
                    //PopularityScore = (int)playlist.PopularityScore
                });
            }
            return playlistDTOs;
        }

        //getPlaylistbyName      but4
        public List<Playlist2DTO> GetPlaylistbyName(string name)
        {
            List<Playlist2DTO> re = new List<Playlist2DTO>();

                var playlists = db.Playlists
                    .Where(p => p.PlaylistName.Contains(name))
                    .Select(p => new  { p.PlaylistID, p.PlaylistName})
                    .ToList();
                foreach(var item in playlists)
                {
                re.Add(
                    new Playlist2DTO
                    {
                        PlaylistID = item.PlaylistID,
                        PlaylistName = item.PlaylistName,
                    }
                );
                }
                if (playlists.Count == 0 || !playlists.Any(p => p.PlaylistName.Contains(name)))
                {
                    return null;
                }
                return re;
        }
        //GetAllPlaylistOfUser           but5
        public List<Playlist3DTO> GetAllPlaylistOfListener(string listenerName)
        {
            List<Playlist3DTO> result = new List<Playlist3DTO>();

            var playlists = db.Playlists
                .Join(db.Listeners, p => p.ListenerID, l => l.ListenerID, (p, l) => new { Playlist = p, Listener = l })
                .Where(pl => pl.Listener.Name == listenerName)
                .Select(pl => new { pl.Playlist.PlaylistID, pl.Playlist.PlaylistName, pl.Listener.ListenerID, pl.Listener.Name })
                .ToList();

            foreach (var item in playlists)
            {
                result.Add(new Playlist3DTO
                {
                    PlaylistID = item.PlaylistID,
                    PlaylistName = item.PlaylistName,
                    ListenerID = item.ListenerID,
                    ListenerName = item.Name 
                });
            }

            if (playlists.Count == 0)
            {
                return null;
            }

            return result;
        }


        //GetAllSongOfPlaylist         but6
        public List<SongDTO> GetAllSongOfPlaylist(string playlistName)
        {
            List<SongDTO> result = new List<SongDTO>();

            var songs = db.Songs
                .Join(db.PlaylistSongs, s => s.SongID, ps => ps.SongID, (s, ps) => new { Song = s, PlaylistSong = ps })
                .Join(db.Playlists, sp => sp.PlaylistSong.PlaylistID, p => p.PlaylistID, (sp, p) => new { sp.Song.SongID, sp.Song.SongName, p.PlaylistName })
                .Where(sp => sp.PlaylistName == playlistName)
                .ToList();

            foreach (var item in songs)
            {
                result.Add(new SongDTO
                {
                    PlaylistName = item.PlaylistName,
                    SongID = item.SongID,
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
        //AddPlaylist
        //ModifyPlaylist


    }
}
*/