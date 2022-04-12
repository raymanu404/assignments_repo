using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Domain.ValueObjects
{
    public record struct Password
    {
        public string Value { get; set; }
        Regex hasNumber = new Regex(@"[0-9]+");
        Regex hasUpperChar = new Regex(@"[A-Z]+");
        Regex hasMinimum8Chars = new Regex(@".{8,}");

        public Password(string value)
        {
            if(value == null)
            {
                throw new ArgumentNullException("value");
            }

            if(hasNumber.IsMatch(value) && hasUpperChar.IsMatch(value) && hasMinimum8Chars.IsMatch(value))
            {
                Value = value;
            }
            else
            {
                //invalid password
                Value = "";
            }
           
        }

       
    }
}
