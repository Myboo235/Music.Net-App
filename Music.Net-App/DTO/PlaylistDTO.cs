using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Net_App.DAL.Huy
{
    internal class PlaylistListenerDTO
    {
        public string Name { get; set; }
        public string PlaylistName { get; set; }
    }
    internal class PlaylistSongDTO
    {
        public string PlaylistName { get; set; }
        public string SongName { get; set; }
    }
}
