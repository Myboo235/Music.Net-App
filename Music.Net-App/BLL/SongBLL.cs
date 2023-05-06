/*using Music.Net_App.DAL.Huy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Music.Net_App.DAL;

namespace Music.Net_App.BLL
{
    internal class UserBLL
    {
        MusicNetAppEntities1 db = new MusicNetAppEntities1();
        public List<Song1DTO> GetAllSongs()
        {
            List<Song1DTO> songDTOs = new List<Song1DTO>();
            List<Song> songs = db.Songs.ToList();
            foreach (Song song in songs)
            {
                songDTOs.Add(new Song1DTO
                {
                    SongID = song.SongID,
                    //ArtistID = (int)song.ArtistID,
                    SongName = song.SongName,
                    //Datecreated = (DateTime)song.DateCreated,
                    //Duration = (int)song.Duration
                });
            }
            return songDTOs;
        }

        public List<Song2DTO> GetSongByName(string name)
        {
            List<Song2DTO> songDTOs = new List<Song2DTO>();
            var songs = db.Songs.Where(s => s.SongName.Contains(name)).Join(
                            db.Artists,
                            song => song.ArtistID,
                            artist => artist.ArtistID,
                            (song, artist) => new { song, artist }
                        );
            foreach (var item in songs)
            {
                songDTOs.Add(new Song2DTO
                {
                    SongName = item.song.SongName,
                    Name = item.artist.Name
                });
            }
            return songDTOs;
        } 
    }
}

*/