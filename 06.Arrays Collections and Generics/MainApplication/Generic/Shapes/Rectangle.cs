using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Shapes
{
    public class Rectangle : Shape
    {
        public int Width { get; }
        public int Height { get; }
        public Rectangle(int width, int height)
        {
            Width = width; 
            Height = height; 
        }
        public override void Draw()
        {
            Console.WriteLine($"Draw your rectangle with {Width} and {Height}");
        }
    }
}
