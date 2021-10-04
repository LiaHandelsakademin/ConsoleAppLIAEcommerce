//using ConsoleAppLIAEcommerce.Models;
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
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Tag> Tags { get; set; }




        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Database=ConsoleAppLIAEcommerce;Trusted_Connection=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // inheritance
            modelBuilder.Entity<Shipping>().HasBaseType<Address>();

            // Seeding
            
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 3,
                    Name = "Ägg",
                    ShortDescription = "Frigående",
                    Description = "Land: Sverige",
                    Price = 25.90m,
                    DiscountedPrice = 19.90m,
                    Status = true
                    

                },
                new Product
                {
                    Id = 4,
                    Name = "Smör",
                    ShortDescription = "Ekologisk",
                    Description = "Land: Tyskland",
                    Price = 10.90m,
                    DiscountedPrice = 7.50m,
                    Status = true

                },
                new Product
                {
                    Id = 5,
                    Name = "Pasta",
                    ShortDescription = "Fussilli",
                    Description = "Land: Italien",
                    Price = 6.50m,
                    DiscountedPrice = 4.50m,
                    Status = false

                }

                );
        }
    }
}
