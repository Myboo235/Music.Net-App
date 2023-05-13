using Music.Net_App.DAL;
using Music.Net_App.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Documents;

namespace Music.Net_App.BLL
{

    //Hamf laay het user ra getAllUsers
    //checkUser(email,passs) -> true
    //Adduser
    //Hamf lay user theo email getUsersByEmail(string email) userid
    //Hamf lay user theo ten getUsersByName(string name)
    //Ham lay playlist cuar user getUserPlaylist(int userid)


    //Ham lay so luong user
    //Ham lay so luong listener
    //Ham lay so luong artist

    public class UserBLL
    {
        EntitiesMusicNetApp db = new EntitiesMusicNetApp();
        // get all listener 
        public List<ListenerDTO> getAllListener()
        {

            List<ListenerDTO> list = new List<ListenerDTO>();
            var getAllListener = from p in db.Listeners
                             join c in db.Countries on p.CountryID equals c.CountryID

                             select new { p.ListenerID, c.CountryName, p.Name, p.Email, p.Password, p.Gender, p.DateJoin };


            foreach (var item in getAllListener.ToList())
            {
                list.Add(new ListenerDTO
                {
                    ListenerID = item.ListenerID,
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

        // get all artist

        /*        public List<ArtistDTO> getAllArtist()
                {
                    List<ArtistDTO> list = new List<ArtistDTO>();
                    var getAllArtist = from a in db.Artists
                                       join c in db.Countries on a.CountryID equals c.CountryID

                                       select new { a.ArtistID, c.CountryName, a.Name, a.Email, a.Password, a.Gender, a.DateJoin };


                    foreach (var item in getAllArtist.ToList())
                    {
                        list.Add(new ArtistDTO
                        {
                            ArtistID = item.ArtistID,
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
        */

        public List<UserDTO> ConvertListenerToUserDTO(List<ListenerDTO> listener)
        {
            List<UserDTO> userDTOs = new List<UserDTO>();
            foreach(var item in listener)
            {
                userDTOs.Add(new UserDTO { 
                        CountryName = item.CountryName,
                        Name = item.Name,
                        Email = item.Email,
                        Password = item.Password,
                        Gender = item.Gender,
                        DateJoin = item.DateJoin
                
                });
            }
            return userDTOs;
        }


        public List<UserDTO> ConvertArtistToUserDTO(List<ArtistDTO> artists)
        {
            List<UserDTO> userDTOs = new List<UserDTO>();
            foreach (var item in artists)
            {
                userDTOs.Add(new UserDTO
                {
                    CountryName = item.CountryName,
                    Name = item.Name,
                    Email = item.Email,
                    Password = item.Password,
                    Gender = item.Gender,
                    DateJoin = item.DateJoin

                });
            }
            return userDTOs;
        }
        public List<UserDTO> getAllUser()
        {
            List<UserDTO> getAllUser = new List<UserDTO>();
            getAllUser.AddRange(ConvertListenerToUserDTO(getAllListener()));
         //   getAllUser.AddRange(ConvertArtistToUserDTO(getAllArtist));
         return getAllUser;
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


        public bool addUser(Listener user)
        {
            try
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


        public ListenerDTO getUsersByEmail(string email)
        {
            ListenerDTO getUserByEmail = new ListenerDTO();
            var getUser = from l in db.Listeners
                          join c in db.Countries on l.CountryID equals c.CountryID
                          where l.Email == email
                          select new { l.ListenerID, c.CountryName, l.Name, l.Email, l.Password, l.Gender, l.DateJoin };
            return getUserByEmail;
        }


        public List<ListenerDTO> getUsersByName(string name)
        {
            List<ListenerDTO> getUserByName = new List<ListenerDTO>();
            var getUser = from l in db.Listeners
                          join c in db.Countries on l.CountryID equals c.CountryID
                          where l.Name.Contains(name)
                          select new { l.ListenerID, c.CountryName, l.Name, l.Email, l.Password, l.Gender, l.DateJoin };
            foreach (var user in getUser)
            {
                getUserByName.Add(new ListenerDTO
                {
                    ListenerID = user.ListenerID,
                    CountryName = user.CountryName,
                    Name = user.Name,
                    Email = user.Email,
                    Password = user.Password,
                    Gender = Convert.ToBoolean(user.Gender),
                    DateJoin = Convert.ToDateTime(user.DateJoin)



                });
            }

            return getUserByName;
        }

        /*      public List<PlayListDTO> getPlaylistOfUser(int userid)
                {
                    List<PlayListDTO> getUserByPlayList = new List<PlayListDTO>();
                    var getPlayList = from l in db.Listeners
                                      join p in db.Playlists on l.ListenerID equals p.ListenerID
                                     where l.ListenerID == userid
                                      select new { p.PlaylistName };
                foreach(var item  in getUserByPlayList.ToList())
                    {
                        getUserByPlayList.Add(new PlayListDTO { 
                        PlaylistName = item.PlaylistName,

                        });
                    }


                    return getUserByPlayList;
                }*/


        public List<ListenerDTO> getUserByPlayList(string PlayListName)
        {
            List<ListenerDTO> getUserByPlayList = new List<ListenerDTO>();
            var getUser = from l in db.Listeners
                          join c in db.Countries on l.CountryID equals c.CountryID
                          where l.Name.Contains(PlayListName)
                          select new { l.ListenerID, c.CountryName, l.Name, l.Email, l.Password, l.Gender, l.DateJoin };
            foreach (var user in getUser)
            {
                getUserByPlayList.Add(new ListenerDTO
                {
                    ListenerID = user.ListenerID,
                    CountryName = user.CountryName,
                    Name = user.Name,
                    Email = user.Email,
                    Password = user.Password,
                    Gender = Convert.ToBoolean(user.Gender),
                    DateJoin = Convert.ToDateTime(user.DateJoin)



                });
            }

            return getUserByPlayList;
        }

        //Ham lay so luong user
        public int getUserCount()
        {
            return db.Listeners.Count();
        }
        //Ham lay so luong listener
        public int getListenerCount()
        {
            return db.Listeners.Count();
        }

        //Ham lay so luong artist
        public int getArtistCount()
        {
            return db.Artists.Count();
        }

        // lich su nghe nhac   
        public List<ListeningHistory> getHistory(int userid)
        {
            List<ListeningHistory> list = new List<ListeningHistory>();
            var getHistory = db.ListeningHistories.Where(p => p.ListenerID == userid).ToList();
            if (getHistory != null)
            {
                foreach (var item in getHistory)
                {
                    list.Add(item);
                }
            }
            return list;
        }
        // ton tai ID return true
        // khong ton tai ID return false
        public bool checkUser(int userid)
        {
            int check = 0;
            foreach (var item in db.Listeners.ToList())
            {
                if (item.ListenerID == userid)
                {
                    check = 1;
                    break;
                }
            }
            if (check == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        /*     // them hoac chinh sua user
             public void AddUser(ListenerDTO user)
             {
                 if (checkUser(user.ListenerID) == true)
                 {
                     //chinh sua thong tin user
                     ModifyUser(user);

                 }
                 else
                 {
                     // add user
                     addUser(user);


                 }

             }
     */
        //AddUser
        public bool addUser(ListenerDTO user)
        {
            Listener l = db.Listeners.Where(p => p.ListenerID == user.ListenerID).FirstOrDefault();
            if (l == null)
            {
                l = new Listener()
                {
                    ListenerID = user.ListenerID,
                    CountryID = SearchIDCountry(user.CountryName),
                    Name = user.Name,
                    Email = user.Email,
                    Password = user.Password,
                    Gender = user.Gender,
                    DateJoin = user.DateJoin
                };

                db.Listeners.Add(l);
                db.SaveChanges();
                return true;
            }
            else return false;

        }


        public int SearchIDCountry(string name)
        {
            int CountryID = -1;
            Country country = db.Countries.Where(p => p.CountryName == name).FirstOrDefault();
            CountryID = country.CountryID;
            return CountryID;

        }


        //ModifyUser
        public bool ModifyListener(ListenerDTO user)
        {


            Listener listener = db.Listeners.Where(p => p.ListenerID == user.ListenerID).FirstOrDefault();
            if (listener != null)
            {
                listener.ListenerID = user.ListenerID;
                listener.CountryID = SearchIDCountry(user.CountryName);
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
            if(Users != null)
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
                   CountryID = user.CountryID,
                   Name = user.Name,
                   Descriptions = user.Description,
                   DateJoin = user.DateJoihn

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
                a.CountryID = user.CountryID;
                a.Name = user.Name;
                a.Descriptions = user.Description;
                a.DateJoin = user.DateJoihn;
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

        }











    }
}


//

