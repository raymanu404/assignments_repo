using Domain.Enums;

namespace Domain.Models
{
    public class Coupouns
    {
        public int Id { get; set; }
        public TypeCoupuns Type { get; set; }
        public DateTime DateCreated { get; set; }
        public string UniqueCode { get; set; } = null!;
        public int UserId { get; set; }


    }
}
