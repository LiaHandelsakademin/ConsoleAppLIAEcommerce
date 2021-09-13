using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLIAEcommerce
{
    public class MainView
    {
        public void RunMainView()
        {
            Console.WriteLine("ConsoleAppLIAEcommerce");
            ProductView ProductView = new ProductView();
            ProductView.RunProductsView();
        }
    }
}
