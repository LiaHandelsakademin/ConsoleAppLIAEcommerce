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
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Warehouses> Warehouses { get; set; }
        public DbSet<Stocks> Stocks { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }




        //public DbSet<ProductCategory> ProductCategories { get; set; }


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
                    ProductId = 1,
                    Name = "Ägg",
                    ShortDescription = "Frigående",
                    Description = "Land: Sverige",
                    Price = 25.90m,
                    DiscountedPrice = 19.90m,
                    Status = true
                    //CategoryId = 1,


                },
                new Product
                {
                    ProductId = 2,
                    Name = "Smör",
                    ShortDescription = "Ekologisk",
                    Description = "Land: Tyskland",
                    Price = 10.90m,
                    DiscountedPrice = 7.50m,
                    Status = true
                    //CategoryId = 1,



                },
                new Product
                {
                    ProductId = 3,
                    Name = "Pasta",
                    ShortDescription = "Fussilli",
                    Description = "Land: Italien",
                    Price = 6.50m,
                    DiscountedPrice = 4.50m,
                    Status = false
                    //CategoryId = 2,



                }

                );
            modelBuilder.Entity<Picture>().HasData(
                new Picture
                {
                PicId = 1,
                PicName = "url 1...",
                Url = "www.hdhd",
                ProductId = 3,
                //CategoryPic = "url C1"
                }
                ,
                new Picture
                {
                    PicId = 2,
                    PicName = "url 2...",
                    Url = "www.hdhd",
                    ProductId = 2,
                    //CategoryPic = "url C2"


                }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    CategoryName = "Mejeri, ost & ägg",
                    CategoryImageUrl = "www. dkd"
                    //CategoryPicture = null 
                }
                ,
                new Category
                {
                    CategoryId = 2,
                    CategoryName = "Vete & Bröd & Pasta",
                    CategoryImageUrl = "www.jdjd"
                    //CategoryPicture = null


                }
                );


            //modelBuilder.Entity<ProductCategory>().HasData(
            //    new ProductCategory
            //    {
            //        CategoryId = 1,
            //        ProductId = 2

            //    }
            //    );


        }
    }
}
