using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace ConsoleAppLIAEcommerce.Models
{
    class ProductCategory
    {
        public int MyProperty { get; set; }

        //[Key]
        //[ForeignKey("Product")]
        //public int ProductId { get; set; }
        //public Product Product { get; set; }
        //[ForeignKey("Category")]
        //public int CategoryId { get; set; }
        //public Category Category { get; set; }
    }
}
