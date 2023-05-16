using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Net_App.DTO
{
    internal class SongDTO
    {
        public string ArtistName { get; set; }
        public string SongName { get; set; }
        public int SongID { get; internal set; }
        public int? ArtistID { get; internal set; }
        public DateTime? DateCreated { get; internal set; }
        public TimeSpan Duration { get; internal set; }
    }
}
