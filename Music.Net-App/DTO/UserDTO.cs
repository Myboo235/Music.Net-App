using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Net_App.DAL
{
    public class UserDTO
    {
        public int UserId { get; set; }
        public string CountryName { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Gender { get; set; }
        public DateTime DateJoin { get; set; }

        public int CountryId { get; set; }
        public string TypeUser { get; set; }
    }


    public class UserHistoryDTO
    {
        public int UserID { get; set; }
        public string ItemType { get; set; }
        public int ItemID { get; set; }
        public DateTime TimeStamp { get; set; }

        public string ItemName { get; set; }
    }


}
