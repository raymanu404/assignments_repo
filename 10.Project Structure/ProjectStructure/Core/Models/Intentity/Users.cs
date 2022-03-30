namespace Domain.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public char Sex { get; set; }
        public bool Confirmed { get; set; }
        public float Balance { get; set; }
        public List<Coupouns> Coupouns { get; set; } = null!;

    }
}