using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticalAssignment.Models.DataEntity
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public Customer Customer { get; set; }
        public int TotalDiscount { get; set; }
        public int TotalAmount { get; set; }
        public string OrderStatus { get; set; }
        

    }
}
