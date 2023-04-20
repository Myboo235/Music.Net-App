using Music.Net_App.DAL.Huy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Net_App.BLL
{
    internal class SongBLL
    {
        public List<Song> getAllsongs()
        {
            using (MusicNetAppEntities1 db = new MusicNetAppEntities1())
            {
                List<Song> songs = db.Songs.ToList();
                return songs;
            }
        }
    }
}
