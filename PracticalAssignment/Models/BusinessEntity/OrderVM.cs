using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using PracticalAssignment.Models.DataEntity;

namespace PracticalAssignment.Models.BusinessEntity
{
    public class OrderVM
    {
        [Display(Name = "Order ID")]
        public int OrderId { get; set; }
        
        [Display(Name = "Order Number")]
        public int OrderNumber { get; set; }

        [Display(Name = "Order Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime OrderDate { get; set; }
        public Customer Customer { get; set; }

        [Display(Name = "Total Discount")]
        public int TotalDiscount { get; set; }

        [Display(Name = "Total Amount")]
        public int TotalAmount { get; set; }

        [Display(Name = "Order Status")]
        public string OrderStatus { get; set; }
        

    }
}
