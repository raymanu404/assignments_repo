using Domain.ValueObjects;

namespace Domain.Models
{
    public class Buyer
    {
        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public PhoneNumber PhoneNumber { get; set; }
        public char Sex { get; set; }
        public bool Confirmed { get; set; }
        public float Balance { get; set; } = 0;
        public List<Coupoun> Coupouns { get; set; } = null!;

    }
}