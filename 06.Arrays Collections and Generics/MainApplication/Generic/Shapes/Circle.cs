using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Shapes
{
    public class Circle : Shape
    {
        public int Radius { get; }

        public Circle(int radius) 
        {
            Radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine($"Draw your circle with radius {Radius} ");
        }
    }
}
