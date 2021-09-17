using ConsoleAppLIAEcommerce.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Text;

namespace ConsoleAppLIAEcommerce
{
    class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountedPrice { get; set; }
        public string Model { get; set; }
        
        // Stock Keeping Unit
        public string SKU { get; set; }

        // Universla Product Code
        public string UPC  { get; set; }
        public int MyProperty { get; set; }

        // Quantity in stock
        public int Quantity { get; set; }

        // The minimum quantity to order
        public int MinimumQuantity { get; set; }

        // true if product can be orderd
        // false if product cannot be ordered
        public bool Status { get; set; }

        // In cm's
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        // In kg's
        public double Weight { get; set; }

        // The URL to the image
        public string MainImageUrl { get; set; }

        // Points collected by the custmer when they buy this product
        public int RewardPoints { get; set; }

        //public ICollection<Category> Categories { get; set; }

        [InverseProperty(nameof(Picture.Product))]
        public ICollection<Picture> Pictures { get; set; }
       

    }
}
