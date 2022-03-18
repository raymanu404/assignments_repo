using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentMain.Assignment
{
    public class Heroes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Power { get; set; }
        public int Age { get; set; }


        public override string ToString()
        {
            return $"Name: {Name} :, with his/her power: {Power} and has Age: {Age} years old";
        }
    }
}
