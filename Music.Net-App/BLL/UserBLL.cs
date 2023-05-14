using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Music.Net_App.DTO;
using Music.Net_App.DAL;
using System.Windows.Forms;

namespace Music.Net_App.BLL
{


    //Hamf laay het user ra getAllUsers
    //checkUser(email,passs) -> true
    //Adduser
    //Hamf lay user theo email getUsersByEmail(string email) userid
    //Hamf lay user theo ten getUsersByName(string name)
    //Ham lay playlist cuar user getUserPlaylist(int userid)




    public class UserBLL {
        EntitiesMusicNetApp db = new EntitiesMusicNetApp();
        public List<UserDTO> getAllUser()//get alllisste//
        {
       
        List<UserDTO> list = new List<UserDTO>();

              //var lis = db.Listeners.Select(p => new { p.ListenerID, p.CountryID, p.Name, p.Email, p.Password, p.Gender, p.DateJoin  });
           
            //list.AddRange(db.Listeners.Select(p => new { p.ListenerID, p.Country, p.Name, p.Email, p.Password, p.Gender, p.DateJoin  }).ToList();
            var getAlluser = from p in db.Listeners
                             from b in db.Artists
                             join c in db.Countries on p.CountryID equals c.CountryID
                             select new { p.ListenerID, c.CountryName, p.Name, p.Email, p.Password, p.Gender, p.DateJoin };
       
            //MessageBox.Show(getAlluser.T)
            foreach (var item in getAlluser.ToList())
            {
                list.Add(new UserDTO
                {
                    UserId = item.ListenerID,
                    CountryName = item.CountryName,
                    Name = item.Name,
                    Email = item.Email,
                    Password = item.Password,
                    Gender = Convert.ToBoolean(item.Gender),
                    DateJoin = Convert.ToDateTime(item.DateJoin)



                });
         
            }

            return list;
        }

        public bool CheckEmail(string email)
        {
            // true chua ton tai tai khoan
            var check = db.Listeners.Where(p => p.Email == email).FirstOrDefault();
            if (check != null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public bool checkUser(string email, string pass)
        {
            // true chua ton tai tai khoan
            var check = db.Listeners.Where(p => p.Email == email && p.Password == pass).FirstOrDefault();
            if (check != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //get Last ID
        //Add Listener
        //Add Artisr
        //Modify Listener
        //Modify Artisr
        public bool addUser(Listener user)
        {
            try//lay ra id cuoi
            {
                db.Listeners.Add(user);
                
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public UserDTO getUsersByEmail(string email)
        {
  
            var getUser = (from u in db.Listeners
                           join c in db.Countries on u.CountryID equals c.CountryID
                           where u.Email == email
                           select new {
                              u.ListenerID,
                              u.Name,
                              u.Email,
                              u.Password,
                              u.Gender,
                              u.DateJoin,
                              c.CountryName
                           }).FirstOrDefault();
            if (getUser != null)
            {
                return new UserDTO
                {
                    UserId = getUser.ListenerID,
                    Name = getUser.Name,
                    Email = getUser.Email,
                    Password = getUser.Password,
                    CountryName = getUser.CountryName,
                    Gender = Convert.ToBoolean(getUser.Gender),
                    DateJoin = Convert.ToDateTime(getUser.DateJoin),
                };
            }
            return null;
            
        }


        public List<Listener> getUsersByName(string name)
        {
            List<Listener> list = new List<Listener>();
            var getUser = db.Listeners.Where(p => p.Name == name).ToList();
            if (getUser != null)
            {
                foreach (var item in getUser)
                {
                    list.Add(item);
                }
            }
            return list;
        }

        public List<Playlist> getUserPlaylist(int userid)
        {
            List<Playlist> list = new List<Playlist>();
            var getPlaylist = db.Playlists.Where(p => p.ListenerID == userid).ToList();
            if (getPlaylist != null)
            {
                foreach (var item in getPlaylist)
                {
                    list.Add(item);
                }
            }
            return list;
        }

        public List<UserHistoryDTO> GetHistory(int userId)
        {
            List<UserHistoryDTO> list = new List<UserHistoryDTO>();

            var getHistory = from h in db.ListeningHistories
                             join s in db.Songs 
                                on new { h.ItemType, h.ItemID } 
                                equals new { ItemType = "Song", ItemID = s.SongID } 
                                into songGroup
                             from song in songGroup.DefaultIfEmpty()
                             join a in db.Albums
                                on new { h.ItemType, h.ItemID }
                                equals new { ItemType = "Album", ItemID = a.AlbumID }
                                into albumGroup
                             from album in albumGroup.DefaultIfEmpty()
                             join p in db.Playlists
                                on new { h.ItemType, h.ItemID }
                                equals new { ItemType = "Playlist", ItemID = p.PlaylistID }
                                into playlistGroup
                             from playlist in playlistGroup.DefaultIfEmpty()
                             where h.ListenerID == userId
                             select new
                             {
                                 h.ItemID,
                                 h.ItemType,
                                 h.ListenerID,
                                 h.Timestamp,
                                 ItemName = (h.ItemType == "Song" && song != null) ? song.SongName :
                                            (h.ItemType == "Album" && album != null) ? album.AlbumName :
                                            (h.ItemType == "Playlist" && playlist != null) ? playlist.PlaylistName : null

                             };

            if (getHistory != null)
            {
                foreach (var item in getHistory)
                {
                    list.Add(new UserHistoryDTO
                    {
                        UserID = (int)item.ListenerID,
                        ItemType = item.ItemType,
                        ItemID = item.ItemID,
                        TimeStamp = Convert.ToDateTime(item.Timestamp),
                        ItemName = item.ItemName
                    });
                }
            }
            return list;
        }


        //ModifyUser
/*        public bool ModifyListener(ListenerDTO user)
        {


            Listener listener = db.Listeners.Where(p => p.ListenerID == user.ListenerID).FirstOrDefault();
            if (listener != null)
            {
                listener.ListenerID = user.ListenerID;
                //listener.CountryID = SearchIDCountry(user.CountryName);
                listener.Name = user.Name;
                listener.Email = user.Email;
                listener.Password = user.Password;
                listener.Gender = user.Gender;
                listener.DateJoin = user.DateJoin;
                db.SaveChanges();
                // db.Listeners.Add(listener);
                return true;
            }
            else return false;


        }

        //DeleteUser
        public bool DeleteUser(int userID)
        {
            var Users = db.Listeners.Where(p => p.ListenerID == userID).FirstOrDefault();
            if (Users != null)
            {
                db.Listeners.Remove(Users);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }

        //Add Artist
        public bool AddArtist(ArtistDTO user)
        {
            Artist a = db.Artists.Where(p => p.ArtistID == user.ArtistID).FirstOrDefault();
            if (a == null)
            {
                a = new Artist()
                {
                    ArtistID = user.ArtistID,
                    //CountryID = user.CountryID,
                    Name = user.Name,
                    //Descriptions = user.Description,
                    //DateJoin = user.DateJoihn

                };

                db.Artists.Add(a);
                db.SaveChanges();
                return true;
            }
            else return false;
        }

        //Modify Artist
        public bool ModifyArtist(ArtistDTO user)
        {


            Artist a = db.Artists.Where(p => p.ArtistID == user.ArtistID).FirstOrDefault();
            if (a != null)
            {
                a.ArtistID = user.ArtistID;
                //a.CountryID = user.CountryID;
                a.Name = user.Name;
                //a.Descriptions = user.Description;
                //a.DateJoin = user.DateJoihn;
                db.SaveChanges();
                return true;
            }
            else return false;


        }



        public bool DeleteArtist(ArtistDTO user)
        {
            var a = db.Artists.Where(p => p.ArtistID != user.ArtistID).FirstOrDefault();
            if (a != null)
            {
                db.Artists.Remove(a);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }*/

    }
}

