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

        //AddSong
        public void AddSong(SongDTO songDTO)
        {

            Song song = new Song
            {
                SongName = songDTO.SongName,
                // Nơi thêm các thuộc tính của bài hát
            };
            db.Songs.Add(song);
            db.SaveChanges();
        }

        //ModifySong
        public bool ModifySong(SongDTO songDTO)
        {
            // Tìm bài hát theo ID
            Song song = db.Songs.FirstOrDefault(s => s.SongID == songDTO.SongID);

            if (song != null)
            {
                song.SongName = songDTO.SongName;
                song.ArtistID = songDTO.ArtistID;
                song.DateCreated = songDTO.DateCreated;
                //song.Duration = songDTO.Duration;

                db.SaveChanges();

                Console.WriteLine("Sửa đổi bài hát thành công.");
                return true;
            }

            Console.WriteLine("Không tìm thấy bài hát");
            return false;

        }
    }
}

