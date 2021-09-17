using ConsoleAppLIAEcommerce.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLIAEcommerce
{
    class MyDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        string connectionString = "Server=DESKTOP-PH8D08N\\SQLEXPRESS;Database=ConsoleAppLIAEcommerce;Trusted_Connection=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Ägg",
                    ShortDescription = "Frigående",
                    Description = "Land: Sverige",
                    Price = 25.90m,
                    DiscountedPrice = 19.90m,
                    Status = true


                },
                new Product
                {
                    Id = 2,
                    Name = "Smör",
                    ShortDescription = "Ekologisk",
                    Description = "Land: Tyskland",
                    Price = 10.90m,
                    DiscountedPrice = 7.50m,
                    Status = true

                },
                new Product
                {
                    Id = 3,
                    Name = "Pasta",
                    ShortDescription = "Fussilli",
                    Description = "Land: Italien",
                    Price = 6.50m,
                    DiscountedPrice = 4.50m,
                    Status = false

                } 

                );
            modelBuilder.Entity<Picture>().HasData(
                new Picture
                {
                PicId = 1,
                PicName = "url 1..."
                },
                new Picture
                {
                    PicId = 2,
                    PicName = "url 2..."

                }
            );
        }
    }
}
