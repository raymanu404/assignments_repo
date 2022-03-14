using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    public interface IBikeSpeed
    {
        public float Time { get; set; }
        public float Distance { get; set; }
        public float CalculateSpeed();
    }
}
