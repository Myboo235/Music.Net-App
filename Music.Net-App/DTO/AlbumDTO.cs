using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music.Net_App.DTO
{
    public class AlbumDTO
    {
        public int ArtistID { get; set; }
        public string ArtistName { get; set; }
        public string AlbumName { get; set; }
        public int AlbumID { get; set; }
        public int GenreID { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int PopularityScore { get; set; }
        public int Duration { get; set; }
        


        
    }
}
