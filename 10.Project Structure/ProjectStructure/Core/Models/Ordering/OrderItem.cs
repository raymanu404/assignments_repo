
namespace Domain.Models
{
    public class OrderItem
    {

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public float Price { get; set; }
        public string Image { get; set; } = null!;
        public Order Order { get; set; }
        public int OrderId { get; set; }
    }
}
