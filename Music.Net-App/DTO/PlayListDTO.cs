using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Net_App.DTO
{
    public class PlayListDTO
    {
        public string PlaylistName { get; set; }

        public static implicit operator PlayListDTO(UserDTO v)
        {
            throw new NotImplementedException();
        }
    }
}
