using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleAppLIAEcommerce.Models
{
    class Stocks
    {
        [Key]
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [ForeignKey("Warehouses")]
        public int WarehouseId { get; set; }
        public Warehouses Warehouses { get; set; }

        public int Quantity { get; set; }



    }
}
