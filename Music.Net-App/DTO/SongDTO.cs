using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Net_App.DTO
{
    public class Song1DTO
    {
        public int SongID { get; set; }

        public string SongName { get; set; }
    }
    public class Song2DTO
    {
        public string SongName { get; set; }
        public string Name { get; set; }
    }
    public class Song3DTO
    {
        public int SongID { get; set; }

        public string SongName { get; set; }
    }
    public class Song4DTO
    {
        public int SongID { get; set; }
        public int ArtistID { get; set; }
        public string SongName { get; set; }
        public DateTime DateCreated { get; set; }
        public TimeSpan Duration { get; set; }
    }
}
