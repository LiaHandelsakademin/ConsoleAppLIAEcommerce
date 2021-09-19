using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace ConsoleAppLIAEcommerce.Models
{
    class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public ICollection<ProductCategory> ProductCategories { get; set; }

    }
}
