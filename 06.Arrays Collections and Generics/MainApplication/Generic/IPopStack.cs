using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public interface IPopStack<out T>
    {
        public T Pop();
    }
}
