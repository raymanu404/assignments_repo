using Generic.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public interface IPushStack<in T>
    {
        public void Push(T item);

    }
}
