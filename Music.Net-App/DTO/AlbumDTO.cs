﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Net_App.DTO
{
    public class AlbumDTO
    {
        public string AlbumName { get; set; }
        public int AlbumID { get; set; }
        public int GenreID { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int PopularityScore { get; set; }
        public int Duration { get; set; }
        
        
    }
}
