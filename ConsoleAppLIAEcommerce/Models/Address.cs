using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleAppLIAEcommerce.Models
{
    class Address
    {
        
        public int AddressId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Address1 { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }


        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
       
    }
}
