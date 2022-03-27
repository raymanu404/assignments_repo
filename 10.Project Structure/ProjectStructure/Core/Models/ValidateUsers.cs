namespace Core.Models
{
    public class ValidateUsers
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Code { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
    }
}
