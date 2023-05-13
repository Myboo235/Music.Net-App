using Music.Net_App.DAL.Huy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Music.Net_App.DAL;


namespace Music.Net_App.BLL
{
    internal class SongBLL
    {
        EntitiesMusicNetApp db = new EntitiesMusicNetApp();

        //GetAllSongs
        public List<SongArtistDTO> GetAllSongs()
        {
            List<SongArtistDTO> songDTOs = new List<SongArtistDTO>();
            var songs = db.Songs.Join(
                db.Artists,
                song => song.ArtistID,
                artist => artist.ArtistID,
                (song, artist) => new { song, artist }
            );

            foreach (var item in songs)
            {
                songDTOs.Add(new SongArtistDTO
                {
                    SongName = item.song.SongName,
                    Name = item.artist.Name
                });
            }

            return songDTOs;
        }


        //GetSongByName
        public List<SongArtistDTO> GetSongByName(string name)
        {
            List<SongArtistDTO> songDTOs = new List<SongArtistDTO>();
            var songs = db.Songs.Where(s => s.SongName.Contains(name)).Join(
                            db.Artists,
                            song => song.ArtistID,
                            artist => artist.ArtistID,
                            (song, artist) => new { song, artist }
                        );
            foreach (var item in songs)
            {
                songDTOs.Add(new SongArtistDTO
                {
                    SongName = item.song.SongName,
                    Name = item.artist.Name
                });
            }
            return songDTOs;
        }

        //AddSong
        public void AddSong(SongUpdateDTO songDTO)
        {
            // Kiểm tra xem bài hát đã tồn tại hay chưa
            bool dup = db.Songs.Any(s => s.SongName == songDTO.SongName);
            if (dup)
            {
                MessageBox.Show("Bài hát đã tồn tại trong danh sách!");
                return;
            }

            Song song = new Song
            {
                SongName = songDTO.SongName,
                ArtistID = songDTO.ArtistID,
                DateCreated = songDTO.DateCreated,
                Duration = songDTO.Duration
            };

            db.Songs.Add(song);
            db.SaveChanges();

            MessageBox.Show("Thêm bài hát thành công!");
        }


        //ModifySong
        public bool ModifySong(SongUpdateDTO songDTO)
        {
            // Tìm bài hát theo ID
            Song song = db.Songs.FirstOrDefault(s => s.SongID == songDTO.SongID);

            if (song != null)
            {
                song.SongName = songDTO.SongName;
                song.ArtistID = songDTO.ArtistID;
                song.DateCreated = songDTO.DateCreated;
                song.Duration = songDTO.Duration;

                db.SaveChanges();
                MessageBox.Show("Sửa đổi bài hát thành công.");
                return true;
            }

            MessageBox.Show(" Không tìm thấy bài hát");
            return false;

        }
        //DeleteSong
        public bool DeleteSong(string songName)
        {
            Song song = db.Songs.FirstOrDefault(s => s.SongName == songName);

            if (song != null)
            {
                db.Songs.Remove(song);
                db.SaveChanges();

                MessageBox.Show("Xóa bài hát thành công.");
                return true;
            }

            MessageBox.Show("Không tìm thấy bài hát.");
            return false;
        }
    }
}


