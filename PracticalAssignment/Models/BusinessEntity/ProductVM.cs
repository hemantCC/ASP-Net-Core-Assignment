using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace PracticalAssignment.Models.BusinessEntity
{
    public class ProductVM
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage ="Product Name is Required!")]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }


        [Required(ErrorMessage = "Provide Category!")]
        public string Category { get; set; }


        [Required(ErrorMessage = "Unit is Required!")]
        public string Unit { get; set; }

        [Required(ErrorMessage = "Unit Price Amount is Required!")]
        [Display(Name = "Unit Price")]
        public int UnitPrice { get; set; }


        [Required(ErrorMessage = "Please Provide Discount Amount also id 0!")]
        [Display(Name = "Discount")]
        public int ApplicableDiscount { get; set; }

        public string Photo { get; set; }


        [Required(ErrorMessage = "Select Status!")]
        public string Status { get; set; }


        
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    
        public int Quantity { get; set; }
        public string ProductRetailer { get; set; }

    }
}
