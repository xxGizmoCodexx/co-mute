﻿using co_mute_be.Models;
using Microsoft.EntityFrameworkCore;

namespace co_mute_be.Database
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; } = null!;

        public DbSet<CarPoolOpp> CarPoolOpps { get; set; } = null!;

        public DbSet<CarPoolBooking> CarPoolBookings { get; set; } = null!;

        //#region Required
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<User>()
        //        .Property(b => b.Phone)
        //        .I();
        //}
        //#endregion
    }
}