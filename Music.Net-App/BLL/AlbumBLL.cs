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
        private static AlbumBLL _Instance;
        public static AlbumBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new AlbumBLL();
                }
                return _Instance;
            }
            private set { }
        }

        EntitiesMusicNetApp db = new EntitiesMusicNetApp();

        public AlbumDTO GetAlbumById(int albumID)
        {
            AlbumDTO ad = new AlbumDTO();
            try
            {
                var album = (from p in db.Albums
                            where p.AlbumID == albumID
                            select p).First();
                if (album != null)
                {
                    ad = new AlbumDTO
                    {

                        AlbumID = album.AlbumID,
                   
                        GenreID = Convert.ToInt32(album.GenreID),
                        AlbumName = album.AlbumName,
                        ReleaseDate = Convert.ToDateTime(album.ReleaseDate),
                        PopularityScore = Convert.ToInt32(album.PopularityScore),
                        Duration = Convert.ToInt32(album.Duration),


                    };
                }

                return ad;

            } catch (Exception ex)
            {
                return ad;
            }
        }
       
        
        public List<AlbumDTO> GetAllAlbumOfArtist(int artistID)
        {
            List<AlbumDTO> result = new List<AlbumDTO>();

            var albums = from p in db.Albums
                        where p.ArtistID == artistID
                        select p;

            if (albums.Any())
            {
                foreach (var item in albums.ToList())
                {
                    result.Add(new AlbumDTO
                    {
                       
                        AlbumID = item.AlbumID,
                        AlbumName = item.AlbumName,
              
                        GenreID = Convert.ToInt32(item.GenreID),
                        PopularityScore = Convert.ToInt32(item.PopularityScore),
                        ReleaseDate = Convert.ToDateTime(item.ReleaseDate),
                        Duration = Convert.ToInt32(item.Duration),
                    });
                }


            }

            return result;
        }

        public int getGenreIdOfArtist(int artistID)
        {
            int genreID = -1;
            foreach(var album in db.Albums)
            {
                if(album.GenreID == artistID) 
                genreID = Convert.ToInt32(album.GenreID);
                break;
            }
            return genreID;
        }

      



        public List<SongDTO> GetAllSongOfAlbum(int albumID)
        {
            List<SongDTO> result = new List<SongDTO>();
            var songs = (from s in db.Songs
                         join ps in db.Albums on s.ArtistID equals ps.ArtistID
                         join p in db.Albums on ps.AlbumID equals p.AlbumID
                         join a in db.Artists on s.ArtistID equals a.ArtistID
                         where p.AlbumID == albumID
                         select new { s.SongID, s.SongName, s.DateCreated, s.Duration, a.ArtistID, a.Name })
                         .ToList();

            if (songs.Any())
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

        public int GetMaxAlbumSongsID()
        {
            var maxColumnValue = (from item in db.Albums
                                  select item.AlbumID).Max();

            return maxColumnValue;
        }


        public bool AddSongToAlbum(int AlbumID, int songID)
        {

            var album = (from p in db.Albums
                            where p.AlbumID == AlbumID
                            select p).FirstOrDefault();
            var song = (from s in db.Songs
                        where s.SongID == songID
                        select s).FirstOrDefault();
            if (album == null || song == null)
            {
                return false;
            }

            var existingSong = (from ps in db.AlbumSongs
                                where ps.AlbumID == AlbumID && ps.SongID == songID
                                select ps).FirstOrDefault();
            if (existingSong != null) return false;


            try
            {
                var newAlbumSong = new AlbumSong
                {
                    AlbumSongID = GetMaxAlbumSongsID() + 1,
                    AlbumID = album.AlbumID,
                    SongID = song.SongID
                };
                db.AlbumSongs.Add(newAlbumSong);
                db.SaveChanges();

                return true;
            }
            catch
            {

                return false;
            }
        }

        public int GetMaxAlbumID()
        {
            var maxColumnValue = (from item in db.Albums
                                  select item.AlbumID).Max();

            return maxColumnValue;
        }

        public bool AddAlbumOfArtist(AlbumDTO albumDTO, int ArtistID)
        {
            try
            {
               Album album= new Album
                {
                  ArtistID = ArtistID,
                  AlbumID = GetMaxAlbumID() +1,
                  AlbumName = albumDTO.AlbumName,
                  GenreID = albumDTO.GenreID,
                  PopularityScore  = Convert.ToInt32(albumDTO.PopularityScore),
                  ReleaseDate = albumDTO.ReleaseDate,
                  Duration = albumDTO.Duration,



                };
                db.Albums.Add(album);
                db.SaveChanges();

                //MessageBox.Show("The album has been successfully added.");
                return true;
            }
            catch (Exception)
            {
                //MessageBox.Show("An error occurred while adding the album.");
                return false;
            }
        }

        public bool RemoveAlbum(int albumID)
        {
            try
            {
                var album = (from p in db.Albums
                                where p.AlbumID == albumID
                                select p).FirstOrDefault();

                if (album != null)
                {
                    db.Albums.Remove(album);
                    db.SaveChanges();

                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



        public bool RemoveSongFromAlbum(int albumID, int songID)
        {
            try
            {
                var AlbumSong = (from As in db.AlbumSongs
                                    where As.AlbumID == albumID && As.SongID == songID
                                    select As).FirstOrDefault();
                if (AlbumSong != null)
                {
                    db.AlbumSongs.Remove(AlbumSong);
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


        public bool ModifyAlbum(AlbumDTO albumDTO)
        {
            try
            {
                var album = (from p in db.Albums
                                where p.AlbumID == albumDTO.AlbumID
                                select p).FirstOrDefault();
                if (album != null)
                {
                   // .PlaylistTyped = playlistDTO.PlaylistType;
                    album.AlbumName = albumDTO.AlbumName;
                    album.ReleaseDate = albumDTO.ReleaseDate;
                    album.PopularityScore = albumDTO.PopularityScore;

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

        
         public List<AlbumDTO> GetAllAlbum()
         {
             List<AlbumDTO> re = new List<AlbumDTO>();

             var n = from album in db.Albums
                     join artist in db.Artists on album.ArtistID equals artist.ArtistID
                     select new { album.AlbumName, artist.Name };
             foreach (var item in n.ToList())
             {
                 re.Add(new AlbumDTO
                 {
                     AlbumName = item.AlbumName,
                    

                 });
             }
             return re;

         }



        public string  GetGenreByIDGenre(int genreID)
        {
            string s = "";
                foreach (var item in db.Genres) {
            
            if(item.GenreID == genreID)
                {
                s = item.GenreName;
                }
                break;
            }
            return s;


        }


        public List<Genre> GetAllGenre()
        {
            List<Genre> re = new List<Genre>();
            var getAllGenre = from Genre genre in db.Genres
                              select new { genre.GenreID, genre.GenreName };
            foreach(var item in getAllGenre)
            {
               re.Add(new Genre
               {
                    GenreID = item.GenreID,
                    GenreName = item.GenreName
                });
            }
            return re;
        }

        /*

         public List<Album> FindAlbumByName(string name)
         {
             var n = from Album album in GetAllAlbum()
                     where album.AlbumName == name
                     select album;
             return n.ToList();

         }

         public List<Song> GetAllSongOfAlbum(string name)
         {
             Album a = FindAlbumByName(name)[0];
             var songID = from AlbumSong s in db.AlbumSongs
                          where s.AlbumID == a.AlbumID
                          select s.SongID;
             List<Song> ls = new List<Song>();
             foreach (int id in songID.ToList())
             {
                 var song = from Song s in db.Songs
                            where s.SongID == id
                            select s;
                 ls.AddRange(song);
             }


             return ls;

         }

         public bool AddAlbum(AlbumDTO albumDTO, int artistID)
         {
             try
             {
                 Album album = new Album();
                 album.AlbumName = albumDTO.AlbumName;
                 album.ArtistID = artistID;
                 db.Albums.Add(album);
                 db.SaveChanges();
                 return true;
             }
             catch
             {
                 return false;
             }
         }


         public bool AddSongToAlbum(int songID, int albumID)
         {
             try
             {
                 AlbumSong albumSong = new AlbumSong();
                 albumSong.AlbumID = albumID;
                 albumSong.SongID = songID;
                 db.AlbumSongs.Add(albumSong);
                 db.SaveChanges();
                 return true;
             }
             catch
             {
                 return false;
             }
         }

         public bool ModifyAlbum(AlbumDTO albumDTO) {
                 try
             {
                     Album album = db.Albums.Find(albumDTO.ArtistName);
                     album.AlbumName = albumDTO.AlbumName;
                     db.SaveChanges();
                     return true;
                 }
                 catch
             {
                     return false;
                 }


         }



         public bool RemoveAlbum(int  id)
         {

             try
             {
                 var album = (from a in db.Albums
                              where a.AlbumID == id
                              select a).FirstOrDefault();
                 if (album != null)
                 {
                     db.Albums.Remove(album);
                     db.SaveChanges();
                 }
                 return true;
             }
             catch
             {
                 return false;
             }
         }


         public bool RemoveSongFromAlbum(int AlbumID, int SongID) 
         {
             try
             {
                 var album = (from a in db.Albums
                              where a.AlbumID == AlbumID
                              select a).FirstOrDefault();
                 if (album != null)
                 {
                     db.Albums.Remove(album);
                     db.SaveChanges();
                     return true;
                 }

                 else return false;

             } 
             catch { return false; }

         }



         public int GetAlbumCount()
         {
             var getCount = from l in db.Albums
                            select l.AlbumID;
             return Convert.ToInt32(getCount.ToList().Max());
         }*/



    }
}
