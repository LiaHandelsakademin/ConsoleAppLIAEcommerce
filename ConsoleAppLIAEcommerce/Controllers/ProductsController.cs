//using ConsoleAppLIAEcommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppLIAEcommerce
{   
    class ProductsController
    {
        MyDbContext MyDbContext = new MyDbContext();
        public void ListProducts()
        {
            Console.WriteLine("Inside ProductsController: Listing products");
            List<Product> AllProducts = MyDbContext.Products.ToList();

            // Print contents of AllProducts
            // Code here...
        }
        public void AddProduct( Product Product )
        {
            Console.WriteLine("Inside ProductsController: Adding a product");
            MyDbContext.Products.Add(Product);
            MyDbContext.SaveChanges();
        }
    }
}
