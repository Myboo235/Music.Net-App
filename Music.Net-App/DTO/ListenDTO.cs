using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Net_App.DTO
{
    public class ListenDTO
    {
        public int ListenerID { get; set; }
        public string CountryName { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Gender { get; set; }
        public DateTime DateJoin { get; set; }//DTO
    }
}
