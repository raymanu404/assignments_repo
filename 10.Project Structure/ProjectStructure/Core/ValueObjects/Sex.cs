using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Domain.ValueObjects
{
    public record struct Sex
    {
        public string Value { get; set; }
        Regex pattern = new Regex(@"M|F");


        public Sex(string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            if (pattern.IsMatch(value) )
            {
                Value = value;
            }
            else
            {
                //invalid sex
                Value = "";
            }

        }


    }
}
