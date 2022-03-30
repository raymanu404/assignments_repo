namespace Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public Categories Category { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public float Price { get; set; }
        public string Image { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool HasStock { get; set; }

    }
}
