using Enums;

namespace Domain.Models
{
    public class Coupon
    {
        public int Id { get; set; }
        public TypeCoupons Type { get; set; }
        public DateTime DateCreated { get; set; }
        public string UniqueCode { get; set; } = null!;
        public Buyer Buyer { get; set; }
        
        //sau cu adnotari
        public int? BuyerId { get; set; }
    }
}
