//using ConsoleAppLIAEcommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace ConsoleAppLIAEcommerce
{   
    class ProductsController
    {
        MyDbContext MyDbContext = new MyDbContext();
        public void ListProducts()
        {
            Console.WriteLine("Inside ProductsController: Listing products");
            List<Product> AllProducts = MyDbContext.Products.ToList();
            foreach (var item in AllProducts)
            {
                Console.WriteLine($"name of the product {item.Name} , description {item.Description}");
            }
            // Print contents of AllProducts
            // Code here...
        }
        public void AddProduct( Product product )
        {
            Console.WriteLine("Inside ProductsController: Adding a product");
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter description: ");
            string description = Console.ReadLine();
            product.Name = name;
            product.Description = description;



            MyDbContext.Products.Add(product);
            MyDbContext.SaveChanges();
        }

        public void DeleteProduct(Product product )
        {
            Console.WriteLine("Enter product id to be deleted: ");
            product.Id =  Convert.ToInt32(Console.ReadLine());

            MyDbContext.Products.Remove(product);
            MyDbContext.SaveChanges();



        }

        public void UpdateProduct(Product product)
        {
            Console.WriteLine("Enter product id to be updated: ");
            product.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter new name: ");
            string name = Console.ReadLine();
            product.Name = name;

            MyDbContext.Entry(product).State = EntityState.Modified;
            MyDbContext.SaveChanges();
        }

        
    }
}
