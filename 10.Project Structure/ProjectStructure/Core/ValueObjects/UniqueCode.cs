using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Domain.ValueObjects
{
    public record struct UniqueCode
    {
        public string Value { get; set; }
        Regex validCode = new Regex(@"^[a-zA-Z0-9]+$");

        public UniqueCode(string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            if (validCode.IsMatch(value) && value.Length == 6)
            {
                Value = value;
            }
            else
            {
                //invalid code
                Value = "";
            }

        }


    }
}
