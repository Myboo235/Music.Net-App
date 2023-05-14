using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Net_App.DAL.Huy
{
    public class SongDTO
    {
        public int SongID { get; set; }

        public string SongName { get; set; }
        public int ArtistID { get; set; }
        public DateTime DateCreated { get; set; }
        public int Duration { get; set; }
    }
    public class SongArtistDTO  
    {
        public string SongName { get; set; }
        public string Name { get; set; }  

    }
    
}
