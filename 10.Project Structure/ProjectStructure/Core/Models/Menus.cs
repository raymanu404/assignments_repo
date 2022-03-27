namespace Core.Models
{
    public class Menus
    {
        public int MenuId { get; set; }
        public Categories Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public string Image { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool inStock { get; set; }

    }
}
