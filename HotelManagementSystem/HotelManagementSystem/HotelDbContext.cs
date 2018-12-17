using HotelManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagementSystem
{
    public class HotelDbContext : DbContext
    {
        public DbSet<Room> Rooms { get; set; }
        public DbSet<KeyCard> KeyCards { get; set; }
        public DbSet<RoomsKeyCards> RoomsKeyCards { get; set; }
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseLazyLoadingProxies()
                    .UseSqlServer(Configuration.ConnectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<RoomsKeyCards>()
        //        .HasKey(x => new {x.RoomId, x.KeyCardId });

        //    modelBuilder.Entity<RoomsKeyCards>()
        //        .HasOne(x => x.Room)
        //        .WithMany(y => y.RoomsKeyCards);

        //    modelBuilder.Entity<RoomsKeyCards>()
        //        .HasOne(x => x.KeyCard)
        //        .WithMany(y => y.RoomsKeyCards);

        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
