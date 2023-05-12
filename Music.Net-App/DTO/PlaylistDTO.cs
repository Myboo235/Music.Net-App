using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Net_App.DTO
{
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
    internal class SongDTO
    {
        public string PlaylistName { get; set; }
        public string SongName { get; set; }
        public int SongID { get; internal set; }
        public int? ArtistID { get; internal set; }
        public DateTime? DateCreated { get; internal set; }
        public TimeSpan Duration { get; internal set; }
    }
}
