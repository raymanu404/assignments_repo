
namespace Domain.Models.Shopping
{
    public class ShoppingCartItem
    {
        public int Id { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
        public Product Product { get; set; }    
        
    }
}
