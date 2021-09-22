using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppLIAEcommerce.Models
{
    class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public string CategoryImageUrl { get; set; }
        public DateTime AddDateTime { get; set; }

        
        public ICollection<Product> Product { get; set; }
        public ICollection<Category> Categories { get; set; }






        //public ICollection<ProductCategory> ProductCategories { get; set; }

    }
}
