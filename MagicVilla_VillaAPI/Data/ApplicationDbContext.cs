using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                            new Villa
                            {
                                Id = 1,
                                Name = "Villa AqzEF",
                                Details = "Modern amenities and spacious rooms",
                                Rate = 123.45,
                                Sqft = 2500,
                                Occupancy = 4,
                                ImageUrl = "https://example.com/image1.jpg",
                                Amenity = "Wi-Fi",
                                CreatedDate = DateTime.Now,
                            },
            new Villa
            {
                Id = 2,
                Name = "Villa GhuTR",
                Details = "Beautiful view of the ocean",
                Rate = 300.75,
                Sqft = 3200,
                Occupancy = 6,
                ImageUrl = "https://example.com/image2.jpg",
                Amenity = "Pool",
                CreatedDate = DateTime.Now,
            },
            new Villa
            {
                Id = 3,
                Name = "Villa WxzYH",
                Details = "Private pool included",
                Rate = 450.00,
                Sqft = 4000,
                Occupancy = 8,
                ImageUrl = "https://example.com/image3.jpg",
                Amenity = "Air Conditioning",
                CreatedDate = DateTime.Now,
            },
            new Villa
            {
                Id = 4,
                Name = "Villa OpqLM",
                Details = "Close to city center",
                Rate = 200.99,
                Sqft = 1500,
                Occupancy = 2,
                ImageUrl = "https://example.com/image4.jpg",
                Amenity = "Gym",
                CreatedDate = DateTime.Now,
            },
            new Villa
            {
                Id = 5,
                Name = "Villa VrjHK",
                Details = "Pet-friendly accommodation",
                Rate = 275.80,
                Sqft = 1800,
                Occupancy = 3,
                ImageUrl = "https://example.com/image5.jpg",
                Amenity = "Free Breakfast",
                CreatedDate = DateTime.Now,
            }
                );
        }
    }
}
