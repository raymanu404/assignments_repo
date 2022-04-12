using Enums;

namespace Domain.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Amount { get; set; }
        public float TotalPrice { get; set; }
        public DateTime DatePlaced { get; set; }
        public OrderStatus Status { get; set; }
        public int Discount { get; set; }
        public string Code { get; set; } = null!;
        public ICollection<OrderItem> Items { get; set; } = null!;
    }
}
