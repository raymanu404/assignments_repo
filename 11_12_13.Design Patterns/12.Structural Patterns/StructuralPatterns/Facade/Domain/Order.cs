using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Order
    {
        public int Id { get; set; } = 0;
        public int UserId { get; set; }
        public int MenuId { get; set; }
        public int Amount { get; set; }
        public float TotalPrice { get; set; }
        public OrderStatus Status { get; set; }

       
    }

    public enum OrderStatus
    {
        Placed,
        InProgress,
        Done
    }
}
