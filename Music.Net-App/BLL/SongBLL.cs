using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Music.Net_App.DAL;
using Music.Net_App.DTO;


namespace Music.Net_App.BLL
{
    internal class SongBLL
    {
        private static SongBLL _Instance;
        public static SongBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new SongBLL();
                }
                return _Instance;
            }
            private set { }
        }
        EntitiesMusicNetApp db = new EntitiesMusicNetApp();

        //GetAllSongs
        public List<SongDTO> GetAllSongs()
        {
            List<SongDTO> songDTOs = new List<SongDTO>();
            List<Song> songs = db.Songs.ToList();
            foreach (Song song in songs)
            {
                songDTOs.Add(new SongDTO
                {
                    SongID = song.SongID,
                    SongName = song.SongName
                });
            }
            return songDTOs;
        }

        //GetSongByName
        public List<SongDTO> GetSongByName(string name)
        {
            List<SongDTO> songDTOs = new List<SongDTO>();
            var songs = from s in db.Songs
                        join a in db.Artists on s.ArtistID equals a.ArtistID
                        where s.SongName.Contains(name)
                        select new { s.SongID , s.SongName , s.DateCreated , s.Duration , a.ArtistID, a.Name };
            foreach (var item in songs)
            {
                songDTOs.Add(new SongDTO
                {
                    SongID = item.SongID,
                    SongName = item.SongName,
                    ArtistName = item.Name,
                    ArtistID = item.ArtistID,
                    Duration = Convert.ToInt32(item.Duration),
                    DateCreated = Convert.ToDateTime(item.DateCreated),

                });
            }
            return songDTOs;
        }

        public SongDTO GetSongByID(int songID)
        {
            SongDTO songDTO = new SongDTO();
            try
            {
                var song = (from s in db.Songs
                             join a in db.Artists on s.ArtistID equals a.ArtistID
                             where s.SongID == songID
                             select new { s.SongID, s.SongName, s.DateCreated, s.Duration, a.ArtistID, a.Name }).FirstOrDefault();
                if(song != null)
                {
                    songDTO = new SongDTO
                    {
                        SongID = song.SongID,
                        SongName = song.SongName,
                        ArtistName = song.Name,
                        ArtistID = song.ArtistID,
                        Duration = Convert.ToInt32(song.Duration),
                        DateCreated = Convert.ToDateTime(song.DateCreated),

                    };
                }

                return songDTO;
            }
            catch(Exception)
            {
                return songDTO;
            }
            
            
        }
        public List<SongDTO> GetAllSongOfArtist(int artistID)
        {
            List<SongDTO> result = new List<SongDTO>();

            var songs = from p in db.Songs
                        where p.ArtistID == artistID
                        select p;

            if (songs.Any())
            {
                foreach (var item in songs.ToList())
                {
                    result.Add(new SongDTO
                    {
                        ArtistName = "",
                        SongName = item.SongName,
                        SongID = item.SongID,
                        ArtistID = item.ArtistID,
                        DateCreated = Convert.ToDateTime(item.DateCreated),
                        Duration = Convert.ToInt32(item.Duration),
                    });
                }


            }

            return result;
        }
        //AddSong
        public int GetMaxSongID()
        {
            var maxColumnValue = (from item in db.Songs
                                  select item.SongID).Max();

            return maxColumnValue;
        }
        public bool AddSong(SongDTO songDTO, int userID)
        {
            try
            {
                Song song = new Song
                {
                    SongID = GetMaxSongID() + 1,
                    ArtistID = userID,
                    SongName = songDTO.SongName,
                    DateCreated = songDTO.DateCreated,
                    Duration = songDTO.Duration,
                };
                db.Songs.Add(song);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //ModifySong
        public bool ModifySong(SongDTO songDTO)
        {
            
            Song song = (from s in db.Songs
                       where s.SongID == songDTO.SongID
                       select s).FirstOrDefault();

            if (song != null)
            {
                song.SongName = songDTO.SongName;
                song.ArtistID = songDTO.ArtistID;
                song.DateCreated = songDTO.DateCreated;
                song.Duration = songDTO.Duration;
                db.SaveChanges();
                return true;
            }

            return false;

        }

        public bool RemoveSong(int songID)
        {
            try
            {
                var song = (from s in db.Songs
                                where s.SongID == songID
                                select s).FirstOrDefault();

                if (song != null)
                {
                    db.Songs.Remove(song);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

