using Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.ShoppingCart
{
    public class Cart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Amount { get; set; }
        public float TotalPrice { get; set; }
        public DateTime DatePlaced { get; set; }
        public int Discount { get; set; }
        public string Code { get; set; } = null!;
        public List<Product> Products { get; set; }
    }
}
