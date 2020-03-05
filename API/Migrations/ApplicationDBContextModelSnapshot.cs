﻿// <auto-generated />

using System;
using AgenciaViajes.API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace AgenciaViajes.API.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("API.Entities.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Cost")
                        .HasColumnType("REAL");

                    b.Property<int>("IdClient")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdTravelPackage")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("IdClient");

                    b.HasIndex("IdTravelPackage");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("API.Entities.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cellphone")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("API.Entities.TravelPackage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TravelPackages");
                });

            modelBuilder.Entity("API.Entities.Booking", b =>
                {
                    b.HasOne("API.Entities.Client", "Client")
                        .WithMany("TravelPackages")
                        .HasForeignKey("IdClient")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Entities.TravelPackage", "TravelPackage")
                        .WithMany("Clients")
                        .HasForeignKey("IdTravelPackage")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("API.Entities.TravelPackage", b =>
                {
                    b.OwnsOne("API.Entities.TouristPlace", "TouristPlace", b1 =>
                        {
                            b1.Property<int>("TravelPackageId")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("DescriptionTouristPlace")
                                .HasColumnType("TEXT");

                            b1.Property<string>("NameTouristPlace")
                                .HasColumnType("TEXT");

                            b1.HasKey("TravelPackageId");

                            b1.ToTable("TravelPackages");

                            b1.WithOwner()
                                .HasForeignKey("TravelPackageId");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
