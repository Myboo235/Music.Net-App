using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Net_App.DTO
{
    public class ArtistDTO
    {

        public int ArtistID { get; set; }
        public int CountryID { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateJoihn { get; set; }

    }
}
