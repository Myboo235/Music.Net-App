using Music.Net_App.DAL.Huy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Music.Net_App.DAL;
using System.Data.Entity;

namespace Music.Net_App.BLL
{
    internal class SongBLL
    {
        EntitiesMusicNetApp db = new EntitiesMusicNetApp();

        //GetAllSongs
        public List<SongArtistDTO> GetAllSongs()
        {
            var songs = (
                from song in db.Songs
                join artist in db.Artists on song.ArtistID equals artist.ArtistID
                select new { song, artist }
            ).ToList();

            List<SongArtistDTO> songDTOs = new List<SongArtistDTO>();
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
            var songs = (
                from song in db.Songs
                join artist in db.Artists on song.ArtistID equals artist.ArtistID
                where song.SongName.Contains(name)
                select new { song, artist }
            ).ToList();

            List<SongArtistDTO> songDTOs = new List<SongArtistDTO>();
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
        public bool AddSong(SongDTO songDTO)
        {
            try
            {
                // Tạo một đối tượng Song từ dữ liệu của SongDTO
                Song song = new Song
                {
                    SongName = songDTO.SongName,
                    ArtistID = songDTO.ArtistID,
                    DateCreated = songDTO.DateCreated,
                    Duration = songDTO.Duration
                };

                db.Songs.Add(song);
                db.SaveChanges();

                MessageBox.Show("The song has been successfully added.");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the song.");
                return false;
            }
        }

        //ModifySong
        public bool ModifySong(SongDTO songDTO)
        {
            try
            {
                Song song = new Song
                {
                    SongID = songDTO.SongID,
                    SongName = songDTO.SongName,
                    ArtistID = songDTO.ArtistID,
                    DateCreated = songDTO.DateCreated,
                    Duration = songDTO.Duration
                };

                db.Entry(song).State = EntityState.Modified;  // Này tra mạng.
                db.SaveChanges();

                MessageBox.Show("The song has been edited successfully.");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while editing the song.");
                return false;
            }
        }
        
        //RemoveSong
        public bool RemoveSong(int songID)
        {
            try
            {
                Song song = new Song { SongID = songID };
                db.Entry(song).State = EntityState.Deleted;  //
                db.SaveChanges();

                MessageBox.Show("The song has been successfully removed.");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while removing the song.");
                return false;
            }
        }
    }
}


