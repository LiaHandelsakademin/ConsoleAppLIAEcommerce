using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLIAEcommerce.Models
{
    class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Telephone { get; set; }
        public string IP { get; set; }
        public DateTime DateAdded { get; set; }

        public Address Address { get; set; }
       
        /*
        public BillingAddress BillingAddress { get; set; }
        public DeliveryAddress DeliveryAddress { get; set; }
        */
    }
}
