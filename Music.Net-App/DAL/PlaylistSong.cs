//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Music.Net_App.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class PlaylistSong
    {
        public Nullable<int> PlaylistID { get; set; }
        public Nullable<int> SongID { get; set; }
        public int SongOder { get; set; }
        public Nullable<System.DateTime> DateAdded { get; set; }
    
        public virtual Playlist Playlist { get; set; }
        public virtual Song Song { get; set; }
    }
}
