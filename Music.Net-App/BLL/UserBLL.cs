﻿using System;
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

        private static UserBLL _Instance;
        public static UserBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new UserBLL();
                }
                return _Instance;
            }
            private set { }
        }
        EntitiesMusicNetApp db = new EntitiesMusicNetApp();
        public List<UserDTO> GetAllUser()
        {
       
        List<UserDTO> list = new List<UserDTO>(); 
        var getAllListener = from p in db.Listeners
                         join c in db.Countries on p.CountryID equals c.CountryID
                         select new { p.ListenerID, c.CountryName, p.Name, p.Email, p.Password, p.Gender, p.DateJoin , p.CountryID};
       
        foreach (var item in getAllListener.ToList())
        {
                list.Add(new UserDTO
                {
                    UserId = item.ListenerID,
                    CountryName = item.CountryName,
                    Name = item.Name,
                    Email = item.Email,
                    Password = item.Password,
                    Gender = Convert.ToBoolean(item.Gender),
                    DateJoin = Convert.ToDateTime(item.DateJoin),
                    TypeUser = "Listener",
                    CountryId = Convert.ToInt32(item.CountryID)
                });
         
            }

            return list;
        }


        public bool CheckEmail(string email)
        {
            var checkEmailListeners = from l in db.Listeners
                                      where l.Email == email
                                      select l;

            var checkEmailArtists = from a in db.Artists
                                    where a.Email == email
                                    select a;

            return checkEmailListeners.Any() || checkEmailArtists.Any(); // return true if email exists in Listeners or Artists table
        }
        public bool CheckArtist(string email, string pass)
        {
            var checkArtist = from l in db.Artists
                        where l.Email == email && l.Password == pass 
                        select l;
            return checkArtist.Any();

        }

        public bool CheckListener(string email, string pass)
        {
            var checkListener = from l in db.Listeners
                            where l.Email == email && l.Password == pass
                            select l;
            return checkListener.Any();

        }
        //get Last ID
        //Add Listener
        //Add Artisr
        //Modify Listener
        //Modify Artisr

        public UserDTO GetListenerByEmail(string email)
        {
            UserDTO user = new UserDTO();
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
                              u.CountryID,
                              c.CountryName
                           }).FirstOrDefault();
            if (getUser != null)
            {
                user =  new UserDTO
                {
                    UserId = getUser.ListenerID,
                    Name = getUser.Name,
                    Email = getUser.Email,
                    Password = getUser.Password,
                    CountryName = getUser.CountryName,
                    Gender = Convert.ToBoolean(getUser.Gender),
                    DateJoin = Convert.ToDateTime(getUser.DateJoin),
                    CountryId = Convert.ToInt32(getUser.CountryID),
                    TypeUser = "Listener"
                };
            }
            return user;
            
        }

        public UserDTO GetArtistByEmail(string email)
        {
            UserDTO user = new UserDTO();
            var getUser = (from u in db.Artists
                           join c in db.Countries on u.CountryID equals c.CountryID
                           where u.Email == email
                           select new
                           {
                               u.ArtistID,
                               u.Name,
                               u.Email,
                               u.Password,
                               u.Gender,
                               u.DateJoin,
                               u.CountryID,
                               c.CountryName
                           }).FirstOrDefault();
            if (getUser != null)
            {
                user = new UserDTO
                {
                    UserId = getUser.ArtistID,
                    Name = getUser.Name,
                    Email = getUser.Email,
                    Password = getUser.Password,
                    CountryName = getUser.CountryName,
                    Gender = Convert.ToBoolean(getUser.Gender),
                    DateJoin = Convert.ToDateTime(getUser.DateJoin),
                    CountryId = Convert.ToInt32(getUser.CountryID),
                    TypeUser = "Artist"
                };
            }
            return user;

        }

        /*public List<Listener> getUsersByName(string name)
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
        }*/


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

        public int GetListenerCount()
        {
            var getCount = from l in db.Listeners
                           select  l.ListenerID ;
            return Convert.ToInt32(getCount.ToList().Max());
        }
        public int GetArtistCount()
        {
            var getCount = from a in db.Artists
                           select a.ArtistID ;
            return Convert.ToInt32(getCount.ToList().Max());
        }

        public bool AddListener(UserDTO Listener)
        {
            if(Listener == null) return true;
            try
            {
                if (CheckEmail(Listener.Email)) return false;
                Listener listener = new Listener
                {
                    ListenerID = GetListenerCount() + 1,
                    Name = Listener.Name,
                    /*Email = Listener.Email,
                    Password = Listener.Password,
                    Gender = true,
                    DateJoin = Listener.DateJoin,
                    CountryID = 0,
                    Descriptions = "",*/
                    
                };
                //db.Listeners.Add(listener);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool ResetPasswordListener(string email)
        {
            Listener listener = (from l in db.Listeners
                                 where l.Email == email
                                 select l).FirstOrDefault();
            if (listener != null)
            {
                listener.Password = "Muzira123";
                db.SaveChanges();

                return true;
            }


            return false;


        }

        public bool ResetPasswordArtist(string email)
        {
            Artist artist = (from l in db.Artists
                                 where l.Email == email
                                 select l).FirstOrDefault();
            if (artist != null)
            {
                artist.Password = "Muzira123";
                db.SaveChanges();
                return true;
            }


            return false;


        }
        //ModifyUser
        public bool ModifyUser(UserDTO user)
        {
            if (user.TypeUser == "Listener")
            {
                return ModifyListener(user);
            }
            else if (user.TypeUser == "Artist")
            {
                return ModifyArtist(user);
            }
            return false;
        }

        public bool ModifyListener(UserDTO Listener)
        {
            Listener listener = (from l in db.Listeners
                                     where l.ListenerID == Listener.UserId
                                     select l).FirstOrDefault();
            if (listener != null)
            {
                listener.Name = Listener.Name;
                listener.Email = Listener.Email;
                listener.Password = Listener.Password;
                listener.Gender = Listener.Gender;
                listener.DateJoin = Listener.DateJoin;
                listener.CountryID = Listener.CountryId;
                db.SaveChanges();

                return true;
            }
             
            
            return false;


        }

        public bool ModifyArtist(UserDTO Artist)
        {
            Artist artist = (from l in db.Artists
                             where l.ArtistID == Artist.UserId
                             select l).FirstOrDefault();
            if (artist != null)
            {
                artist.Name = Artist.Name;
                artist.Password = Artist.Password;
                artist.Email = Artist.Email;
                artist.Password = Artist.Password;
                artist.Gender = Artist.Gender;
                artist.DateJoin = Artist.DateJoin;
                artist.CountryID = Artist.CountryId;

                db.SaveChanges();

                return true;
            }


            return false;


        }

        //DeleteUser
        public bool DeleteUser(UserDTO user)
        {
            if (user.TypeUser == "Listener") 
            { 
                return DeleteListener(user.UserId);
            } else if(user.TypeUser == "Artist")
            {
                
                return DeleteArtist(user.UserId);
            }
            return false;
        }

        public bool DeleteListener(int listenerId)
        {
            var listener = (from l in db.Listeners
                         where l.ListenerID == listenerId
                         select l).FirstOrDefault();

            if (listener != null) 
            {
                db.Listeners.Remove(listener);
                db.SaveChanges();
                return true;
            }

            return false;
            
        }

        public bool DeleteArtist(int artistId)
        {
            var artist = (from l in db.Artists
                            where l.ArtistID == artistId
                            select l).FirstOrDefault();

            if (artist != null)
            {
                db.Artists.Remove(artist);
                db.SaveChanges();
                return true;
            }

            return false;

        }

        //Add Artist
        public bool AddArtist(UserDTO Artist)
        {
            try
            {
                if (CheckEmail(Artist.Email)) return false;
                Artist artist = new Artist
                {
                    ArtistID = GetArtistCount() + 1,
                    Name = Artist.Name,
                    Email = Artist.Email,
                    Password = Artist.Password,
                    Gender = true,
                    DateJoin = Artist.DateJoin,
                    CountryID = 0,
                    
                };
                db.Artists.Add(artist);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



    }
}

