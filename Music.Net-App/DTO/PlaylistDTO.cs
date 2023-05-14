using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Net_App.DTO
{
    public class PlaylistDTO
    {
        public string PlaylistName { get; set; }
        public string PlaylistType { get; set; }
        public int PlaylistId { get; set;}
        public DateTime DateCreated { get; set; }
        public string Description { get; set; }
        public int PopularityScore { get; set;}

    }
    internal class Playlist1DTO
    {
        public string Name { get; set; }
        public string PlaylistName { get; set; }
    }
    internal class Playlist2DTO
    {
        public int PlaylistID { get; set; }
        public string PlaylistName { get; set; }

    }
    internal class Playlist3DTO
    {
        public string PlaylistName { get; set; }
        public string ListenerName { get; set; }
    }
    
}
