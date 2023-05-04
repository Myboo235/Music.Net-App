using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Net_App.DAL.Huy
{
    internal class Playlist1DTO
    {
        public int PlaylistID { get; set; }
        public int ListenerID { get; set; }
        //public int ArtistID { get; set; }
        //public string PlaylistTyped { get; set; }
        public string PlaylistName { get; set; }
        //public string Descriptions { get; set; }
        //public DateTime DateCreated { get; set; }
        //public double PopularityScore { get; set; }
    }
    internal class Playlist2DTO
    {
        public int PlaylistID { get; set; }
        public string PlaylistName { get; set; }

    }
    internal class Playlist3DTO
    {
        public int PlaylistID { get; set; }
        public string PlaylistName { get; set; }
        public int ListenerID { get; set; }
        public string ListenerName { get; set; } 
    }
    internal class SongDTO
    {
        public int SongID { get; set; }
        public string PlaylistName { get; set; }
        public string SongName { get; set; }
    }
}
