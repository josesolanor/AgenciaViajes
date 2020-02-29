using API.Entities;
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
            //modelBuilder
            //    .Entity<TouristPlace>(eb =>
            //    {
            //        eb.HasNoKey();
            //    });

            modelBuilder
                .Entity<TravelPackage>(eb =>
                {
                    eb.HasKey(x => x.Id);
                    eb.OwnsOne(x => x.TouristPlace);
                });
        }


        public DbSet<TravelPackage> TravelPackages { get; set; }        
        public DbSet<Client> Clients { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }

    //public class OrderConfiguration : IEntityTypeConfiguration<TravelPackage>
    //{
    //    public void Configure(EntityTypeBuilder<TravelPackage> builder)
    //    {
    //        builder.HasKey(x => x.Id);
    //        builder.OwnsOne(x => x.TouristPlaces);
    //    }
    //}
}
