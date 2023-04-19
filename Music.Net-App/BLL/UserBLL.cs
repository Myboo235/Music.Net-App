/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Music.Net_App.DAL.Viet;
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

       // MusicNetAppEntities1 db = new MusicNetAppEntities1();
        public bool Login(string username, string password)
        {
            var user = db.Listeners.Where(x => x.Name == username && x.Password == password).FirstOrDefault();
            if (user != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool Register(string username, string password, string email)
        {
            var user = db.Listeners.Where(x => x.Name == username).FirstOrDefault();
            if (user == null)
            {

                Listener listener = new Listener();
                listener.ListenerID = db.Listeners.Count() + 1;
                listener.Gender = true;
                listener.CountryID = 1;
                listener.Name = username;
                listener.Password = password;
                listener.Email = email;
                listener.DateJoin = DateTime.Now;
                db.Listeners.Add(listener);
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

*/