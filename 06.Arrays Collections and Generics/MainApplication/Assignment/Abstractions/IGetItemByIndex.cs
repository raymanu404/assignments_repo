using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Abstractions
{
    public interface IGetItemByIndex<out T>
    {
        T GetItemByIndex(int index);
    }
}
