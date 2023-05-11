using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Music.Net_App.DAL;
using Music.Net_App.DTO;    
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

    public class UserBLL {
        EntitiesMusicNetApp db = new EntitiesMusicNetApp();
        public List<ListenerDTO> getAllUser()
        {
       
        List<ListenerDTO> list = new List<ListenerDTO>();

              //var lis = db.Listeners.Select(p => new { p.ListenerID, p.CountryID, p.Name, p.Email, p.Password, p.Gender, p.DateJoin  });
           
            //list.AddRange(db.Listeners.Select(p => new { p.ListenerID, p.Country, p.Name, p.Email, p.Password, p.Gender, p.DateJoin  }).ToList();
            var getAlluser = from p in db.Listeners
                             join c in db.Countries on p.CountryID equals c.CountryID

                             select new { p.ListenerID, c.CountryName, p.Name, p.Email, p.Password, p.Gender, p.DateJoin };
       

            foreach (var item in getAlluser)
            {
                list.Add(new ListenerDTO
                {
                    ListenerID = item.ListenerID,
                    CountryName = item.CountryName,
                    Name = item.Name,
                    Email = item.Email,
                    Password = item.Password,
                    Gender = (bool)item.Gender,
                    DateJoin = (DateTime)item.DateJoin
                    
                    

                });
         
            }

            return list;
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


        public List<ListenerDTO> getUsersByEmail(string email)
        {
            List<ListenerDTO> list = new List<ListenerDTO>();
            var getUserByEmail = from l in db.Listeners 
                                 join c in db.Countries on l.CountryID equals c.CountryID
                                 where l.Email == email
                                 select new { l.ListenerID, c.CountryName, l.Name, l.Email, l.Password, l.Gender, l.DateJoin };
            return list;
        }


        public List<ListenerDTO> getUsersByName(string name)
        {
            List<ListenerDTO> list = new List<ListenerDTO>();
            var getUser = from l in db.Listeners
                          join c in db.Countries on l.CountryID equals c.CountryID
                          where l.Name.Contains(name)
                          select new { l.ListenerID, c.CountryName, l.Name, l.Email, l.Password, l.Gender, l.DateJoin };
            return list;
        }

        public List<ListenerDTO> getUserPlaylist(int userid)
        {
            List<ListenerDTO> list = new List<ListenerDTO>();
            var getPlaylist = from l in db.Listeners
                              join c in db.Countries on l.CountryID equals c.CountryID
                              join p in db.Playlists on l.ListenerID equals p.ListenerID
                              where l.CountryID == userid
                              select new { l.ListenerID, c.CountryName, l.Name, l.Email, l.Password, l.Gender, l.DateJoin };

            return list;
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

    }
}

