using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticalAssignment.Models.DataEntity
{
    public class OrderDetail
    {
        [Key]
        public int OrderId { get; set; }
        public string Category { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
        public int Price { get; set; }
        public int Discount { get; set; }
        public int Total { get; set; }
        public int CustomerId { get; set; }

    }
}
