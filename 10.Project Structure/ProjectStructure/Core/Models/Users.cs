namespace Core.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public char Sex { get; set; }
        public bool Confirmed { get; set; }
        public float Balance { get; set; }
        public List<Coupouns> Coupouns { get; set; }

    }
}