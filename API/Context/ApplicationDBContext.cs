﻿using API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Context
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder
                .Entity<TravelPackage>(eb =>
                {
                    eb.HasKey(x => x.Id);
                    eb.OwnsOne(x => x.TouristPlace);
                });

            modelBuilder.Entity<Booking>()
                .HasOne(bc => bc.Client)
                .WithMany(b => b.TravelPackages)
                .HasForeignKey(bc => bc.IdClient);
            modelBuilder.Entity<Booking>()
                .HasOne(bc => bc.TravelPackage)
                .WithMany(c => c.Clients)
                .HasForeignKey(bc => bc.IdTravelPackage);
        }


        public DbSet<TravelPackage> TravelPackages { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }

}
