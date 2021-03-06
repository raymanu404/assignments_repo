
using System.Text.RegularExpressions;

namespace Domain.ValueObjects
{
    public record struct PhoneNumber
    {
        public string Value { get; set; }
        Regex pattern = new Regex(@"^(\+\d{1,2}\s?)?1?\-?\.?\s?\(?\d{3}\)?[\s.-]?\d{3}[\s.-]?\d{4}$");
        public PhoneNumber(string value)
        {
            if(value == null)
            {
                throw new ArgumentNullException("value");
            }

            if (pattern.IsMatch(value))
            {
                Value = value;
            }
            else
            {
                //invalid phonenumber
                Value = "";
            }
            
        }
    }
}
