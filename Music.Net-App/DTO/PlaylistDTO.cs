using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Net_App.DAL.Huy
{
    public class PlaylistDTO
    {
        public int PlaylistID { get; set; }
        public int ListenerID { get; set; }
        public int ArtistID { get; set; }
        public string PlaylistType { get; set; }
        public string PlaylistName { get; set; }
        public string Descriptions { get; set; }
        public DateTime DateCreated { get; set; }
        public int PopularityScore { get; set; }
    }
    public class PlaylistListenerDTO
    {
        public string Name { get; set; }  //name của artist
        public string PlaylistName { get; set; }
    }
    public class PlaylistSongDTO
    {
        public string PlaylistName { get; set; }
        public string SongName { get; set; }
    }

}
