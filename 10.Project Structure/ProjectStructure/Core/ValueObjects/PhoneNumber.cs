
namespace Domain.ValueObjects
{
    public record struct PhoneNumber
    {
        public string Value { get; set; }

        public PhoneNumber(string value)
        {
            if(value == null)
            {
                throw new ArgumentNullException("value");
            }

            Value = value;   
        }
    }
}
