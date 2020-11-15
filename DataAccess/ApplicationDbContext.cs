using DataStructure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace DataAccess
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Style> Styles { get; set; } 
        public DbSet<Song> Songs { get; set; }
        public DbSet<PlayList> PlayLists { get; set; }
        public DbSet<PerformerSong> PerformersSongs { get; set; }
        public DbSet<Performer> Performers { get; set; }
        public DbSet<Mix> Mixes { get; set; }
        public DbSet<Favourite> Favourites { get; set; }
        public DbSet<BeatMaker> BeatMakers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PerformerSong>()
                .HasKey(x => new { x.PerformerID, x.SongID });
        }

    }
}
