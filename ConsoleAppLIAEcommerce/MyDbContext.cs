//using ConsoleAppLIAEcommerce.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLIAEcommerce
{
    class MyDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        string connectionString = "Server=DATOR\\SQLEXPRESS;Database=ConsoleAppLIAEcommerce;Trusted_Connection=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
