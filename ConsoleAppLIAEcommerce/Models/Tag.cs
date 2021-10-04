using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLIAEcommerce.Models
{
    class Tag
    {
        public int TagId { get; set; }
        public string Title { get; set; }

        public List<Customer> customers { get; set; }
    }
}
