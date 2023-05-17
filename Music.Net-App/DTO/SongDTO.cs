using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Net_App.DTO
{
    public class SongDTO
    {
        public string ArtistName { get; set; }
        public string SongName { get; set; }
        public int SongID { get; set; }
        public int? ArtistID { get; set; }
        public DateTime? DateCreated { get; set; }
        public int Duration { get; set; }
    }
}
