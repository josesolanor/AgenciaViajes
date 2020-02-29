using API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Context
{
    public class OrderConfiguration : IEntityTypeConfiguration<TravelPackage>
    {
        public void Configure(EntityTypeBuilder<TravelPackage> builder)
        {
            builder.HasKey(x => x.Id);
            builder.OwnsOne(x => x.TouristPlaces);
        }
    }
}
