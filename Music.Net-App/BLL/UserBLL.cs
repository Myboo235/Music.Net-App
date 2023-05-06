/*using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Music.Net_App.DAL;
*//*using Music.Net_App.DAL.Viet;*//*

namespace Music.Net_App.BLL
{


    //Hamf laay het user ra getAllUsers
    //checkUser(email,passs) -> true
    //Adduser
    //Hamf lay user theo email getUsersByEmail(string email) userid
    //Hamf lay user theo ten getUsersByName(string name)
    //Ham lay playlist cuar user getUserPlaylist(int userid)

   
    public class UserBLL
    {
        MusicNetAppEntities db = new MusicNetAppEntities();

        public List<ListenerDAL> getAllUser()
        {
            List<ListenerDAL> list = new List<ListenerDAL>();

              //var lis = db.Listeners.Select(p => new { p.ListenerID, p.CountryID, p.Name, p.Email, p.Password, p.Gender, p.DateJoin  });
           
            //list.AddRange(db.Listeners.Select(p => new { p.ListenerID, p.Country, p.Name, p.Email, p.Password, p.Gender, p.DateJoin  }).ToList();
            var getAlluser = from p in db.Listeners
                             join c in db.Countries on p.CountryID equals c.CountryID

                             select new { p.ListenerID, c.CountryName, p.Name, p.Email, p.Password, p.Gender, p.DateJoin };
       

            foreach (var item in getAlluser)
            {
                list.Add(new ListenerDAL
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


        public Listener getUsersByEmail(string email)
        {
            Listener user = new Listener();
            var getUser = db.Listeners.Where(p => p.Email == email).FirstOrDefault();
            if (getUser != null)
            {
                user = getUser;
            }
            return user;
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




    }
}


*/