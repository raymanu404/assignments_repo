using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Domain.ValueObjects
{
    public record struct Email
    {
        public string Value { get; set; }
        private const string Pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
        private static readonly Regex validCode = new(Pattern);

        public Email(string value)
        {
            if(value == null)
            {
                throw new ArgumentNullException("value");
            }

            if (validCode.IsMatch(value))
            {
                Value = value;
            }
            else
            {
                //invalid
                Value = "";
            }
            
           
        }

    }
}
