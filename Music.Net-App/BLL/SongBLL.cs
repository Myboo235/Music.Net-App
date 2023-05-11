using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Music.Net_App.DAL;

namespace Music.Net_App.BLL
{
    public class SongBLL
    {

        /*    public List<Song1DTO> GetAllSongs()
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
            }*/
        EntitiesMusicNetApp db = new EntitiesMusicNetApp();
        public  List<Song> GetAllSong()
        {
         
            List<Song> list = new List<Song>();
         

            foreach(Song song in db.Songs.ToList())
            {
                list.Add(new Song
                {
                    SongID = song.SongID,
                    ArtistID = (int)song.ArtistID,
                    SongName = song.SongName,
                   // Datecreated = (DateTime)song.DateCreated,
                    Duration = (int)song.Duration
                });
            }


            return list;
        }
        public List<Song> GetSongByName(string name)
        {
            List<Song> songDTOs = new List<Song>();
            var songs = db.Songs
                        .Where(s => s.SongName.Contains(name))
                        .Join(
                            db.Artists,
                            song => song.ArtistID,
                            artist => artist.ArtistID,
                            (song, artist) => new { song, artist }
                        );
            foreach (var item in songs)
            {
                songDTOs.Add(new Song
                {
                    SongName = item.song.SongName,
                   // Name = item.artist.Name
                });
            }
            return songDTOs;
        }
    }
}

