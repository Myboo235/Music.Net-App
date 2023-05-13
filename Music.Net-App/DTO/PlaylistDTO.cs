using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Net_App.DTO
{
    internal class PlaylistDTO
    {
        public string Name { get; set; }
        public string PlaylistName { get; set; }

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
