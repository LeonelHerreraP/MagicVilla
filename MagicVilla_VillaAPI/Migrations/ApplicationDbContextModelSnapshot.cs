﻿// <auto-generated />
using System;
using MagicVilla_VillaAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MagicVilla_VillaAPI.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("Sqft")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenity = "Wi-Fi",
                            CreatedDate = new DateTime(2024, 6, 1, 11, 39, 31, 500, DateTimeKind.Local).AddTicks(4611),
                            Details = "Modern amenities and spacious rooms",
                            ImageUrl = "https://example.com/image1.jpg",
                            Name = "Villa AqzEF",
                            Occupancy = 4,
                            Rate = 123.45,
                            Sqft = 2500,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "Pool",
                            CreatedDate = new DateTime(2024, 6, 1, 11, 39, 31, 500, DateTimeKind.Local).AddTicks(4621),
                            Details = "Beautiful view of the ocean",
                            ImageUrl = "https://example.com/image2.jpg",
                            Name = "Villa GhuTR",
                            Occupancy = 6,
                            Rate = 300.75,
                            Sqft = 3200,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Amenity = "Air Conditioning",
                            CreatedDate = new DateTime(2024, 6, 1, 11, 39, 31, 500, DateTimeKind.Local).AddTicks(4622),
                            Details = "Private pool included",
                            ImageUrl = "https://example.com/image3.jpg",
                            Name = "Villa WxzYH",
                            Occupancy = 8,
                            Rate = 450.0,
                            Sqft = 4000,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Amenity = "Gym",
                            CreatedDate = new DateTime(2024, 6, 1, 11, 39, 31, 500, DateTimeKind.Local).AddTicks(4624),
                            Details = "Close to city center",
                            ImageUrl = "https://example.com/image4.jpg",
                            Name = "Villa OpqLM",
                            Occupancy = 2,
                            Rate = 200.99000000000001,
                            Sqft = 1500,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Amenity = "Free Breakfast",
                            CreatedDate = new DateTime(2024, 6, 1, 11, 39, 31, 500, DateTimeKind.Local).AddTicks(4625),
                            Details = "Pet-friendly accommodation",
                            ImageUrl = "https://example.com/image5.jpg",
                            Name = "Villa VrjHK",
                            Occupancy = 3,
                            Rate = 275.80000000000001,
                            Sqft = 1800,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
