using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Domain.ValueObjects
{
    public record struct Name
    {
        public string Value { get; set; }
        Regex onlyLetters = new Regex(@"^[a-zA-Z]+$");

        public Name(string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            if (onlyLetters.IsMatch(value))
            {
                Value = value;
            }
            else
            {
                //invalid firstname
                Value = "";
            }

        }

    }
}
