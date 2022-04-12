using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects
{
    public record struct Balance
    {
        public float Value { get; set; }
        public Balance(float value)
        {          
            if (value > 0)
            {
                Value = value;
            }
            else
                Value = 0;

        }


    }
}
