using System;
using System.Collections.Generic;
using System.Text;
//using ConsoleAppLIAEcommerce;

namespace ConsoleAppLIAEcommerce
{
    class ProductView
    {
        public void RunProductsView()
        {
            Console.WriteLine("1. List products");
            Console.WriteLine("2. Add new product");
            Console.WriteLine("3. Edit product");
            Console.WriteLine("4. Delete product");
            Console.WriteLine("5. Show product details");
            string Input = Console.ReadLine();
            if (Input.Equals("1"))
            {
                Product Product = new Product();
                ProductsController ProductsController = new ProductsController();
                ProductsController.ListProducts();
            }
            //if (Input.Equals("2"))
            //{
            //    Product Product = new Product();
            //    ProductsController ProductsController = new ProductsController();
            //    ProductsController.AddProduct(Product);
            //}
            else if (Input.Equals("2"))
            {
                Product Product = new Product();
                ProductsController ProductsController = new ProductsController();
                ProductsController.AddProduct(Product);
            }
            else if (Input.Equals("3"))
            {
                Product product = new Product();
                ProductsController ProductsController = new ProductsController();
                ProductsController.UpdateProduct(product);
            }
            else if (Input.Equals("4"))
            {
                Product product = new Product();
                ProductsController ProductsController = new ProductsController();
                ProductsController.DeleteProduct(product);
            }

        }
    }
}
