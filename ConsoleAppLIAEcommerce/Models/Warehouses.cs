using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleAppLIAEcommerce.Models
{
    class Warehouses
    {
        [Key]
        public int WarehouseId { get; set; }
        public string WarehouseName { get; set; }

        //public Address WarehouseAddress { get; set; }

        public ICollection<Order> Orders { get; set; }

        public Stocks Stocks { get; set; }

    }
}
