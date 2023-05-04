using Music.Net_App.DAL;
using Music.Net_App.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Music.Net_App.BLL
{
    public class AlbumBLL
    {
        public List<AlbumDTO> GetAllAlbum()
        {
            List<AlbumDTO> re = new List<AlbumDTO> ();
            EntitiesMusicNetApp db = new EntitiesMusicNetApp();
            var n = from album in db.Albums
                    join artist in db.Artists on album.ArtistID equals artist.ArtistID
                    select new { album.AlbumName , artist.Name};
            foreach(var item in n.ToList())
            {
                re.Add(new AlbumDTO
                {
                    AlbumName = item.AlbumName,
                    ArtistName = item.Name

                });
            }
            return re;
            
        }

        public List<Album> FindAlbumByName(string name)
        {
            EntitiesMusicNetApp db = new EntitiesMusicNetApp();
            var n = from Album album in GetAllAlbum()
                    where album.AlbumName == name
                    select album;
            return n.ToList();

        }

        public List<Song> GetAllSongOfAlbum(string name)
        {
            EntitiesMusicNetApp db = new EntitiesMusicNetApp();
            Album a = FindAlbumByName(name)[0];
            var songID = from AlbumSong s in db.AlbumSongs
                         where s.AlbumID == a.AlbumID
                         select s.SongID;
            List<Song> ls = new List<Song>();
            foreach(int id  in songID.ToList())
            {
                var song = from Song s in db.Songs
                           where s.SongID == id
                           select s;
                ls.AddRange(song);
            }
            

            return ls;

        }
    }
}
