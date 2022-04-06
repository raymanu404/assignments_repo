using Enums;

namespace Domain.Models
{
    public class Coupoun
    {
        public int Id { get; set; }
        public TypeCoupons Type { get; set; }
        public DateTime DateCreated { get; set; }
        public string UniqueCode { get; set; } = null!;
        public int UserId { get; set; }


    }
}
