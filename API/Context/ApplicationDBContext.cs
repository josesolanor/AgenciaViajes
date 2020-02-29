using API.Entities;
using Microsoft.EntityFrameworkCore;


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
                .Entity<TouristPlace>(eb =>
                {
                    eb.HasNoKey(); 
                });

            modelBuilder
                .Entity<TravelPackage>(eb =>
                {
                    eb.HasKey(x => x.Id);
                    eb.OwnsOne(x => x.TouristPlaces);
                });
        }


        public DbSet<TravelPackage> TravelPackages { get; set; }        
        public DbSet<Client> Clients { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }
}
