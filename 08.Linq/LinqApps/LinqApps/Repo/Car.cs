using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }
        public int CompanyId { get; set; }
        public int MaxSpeed { get; set; }
        public bool IsFullOption { get; set; }

        public override string ToString()
        {
            return $"{Brand} {Model} from Year {Year}, the colour is {Colour}, Speed: {MaxSpeed} {(IsFullOption ? "has full option included " : "")}";
        }
    }
}
