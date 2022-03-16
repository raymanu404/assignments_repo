using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Shapes
{
    public class Square : Rectangle
    {
        public int Side { get; }
        public Square(int _side) : base(_side, _side)
        {
            Side = _side;
        }

        public override void Draw()
        {
            Console.WriteLine($"Length of your square is : {Side}");
        }
    }
}
