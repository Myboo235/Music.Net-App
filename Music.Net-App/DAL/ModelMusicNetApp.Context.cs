﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EntitiesMusicNetApp : DbContext
    {
        public EntitiesMusicNetApp()
            : base("name=EntitiesMusicNetApp")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<AlbumSong> AlbumSongs { get; set; }
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Listener> Listeners { get; set; }
        public virtual DbSet<ListeningHistory> ListeningHistories { get; set; }
        public virtual DbSet<Playlist> Playlists { get; set; }
        public virtual DbSet<PlaylistSong> PlaylistSongs { get; set; }
        public virtual DbSet<Single> Singles { get; set; }
        public virtual DbSet<Song> Songs { get; set; }
    }
}