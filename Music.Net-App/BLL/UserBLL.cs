﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Music.Net_App.DTO;
using Music.Net_App.DAL;
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
        public List<ListenerDTO> getAllUser()
        {
       
        List<ListenerDTO> list = new List<ListenerDTO>();

              //var lis = db.Listeners.Select(p => new { p.ListenerID, p.CountryID, p.Name, p.Email, p.Password, p.Gender, p.DateJoin  });
           
            //list.AddRange(db.Listeners.Select(p => new { p.ListenerID, p.Country, p.Name, p.Email, p.Password, p.Gender, p.DateJoin  }).ToList();
            var getAlluser = from p in db.Listeners
                             join c in db.Countries on p.CountryID equals c.CountryID
                             select new { p.ListenerID, c.CountryName, p.Name, p.Email, p.Password, p.Gender, p.DateJoin };
       
            //MessageBox.Show(getAlluser.T)
            foreach (var item in getAlluser.ToList())
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


        public Listener getUsersByEmail(string email)
        {
  
            var getUser = db.Listeners.Where(p => p.Email == email).FirstOrDefault();
            if (getUser != null)
            {
                return getUser;
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




    
    }
}

