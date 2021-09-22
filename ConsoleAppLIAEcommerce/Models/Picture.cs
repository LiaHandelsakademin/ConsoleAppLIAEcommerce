using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleAppLIAEcommerce.Models
{
    class Picture
    {
        [Key]
        public int PicId { get; set; }
        public string PicName { get; set; }
        public string Url { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }


        public Product Product { get; set; }



    }
}
