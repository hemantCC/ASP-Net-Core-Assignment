using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticalAssignment.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public string ProductRetailer { get; set; }

        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        public string Category { get; set; }

        public string Unit { get; set; }
        
        [Display(Name = "Unit Price")]
        public int UnitPrice { get; set; }

        [Display(Name = "Discount")]
        public int ApplicableDiscount { get; set; }
        
        public string Photo { get; set; }
        
        public string Status { get; set; }

    }
}
