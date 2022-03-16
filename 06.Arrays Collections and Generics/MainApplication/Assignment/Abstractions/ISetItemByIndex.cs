using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Abstractions
{
    public interface ISetItemByIndex<in T>
    {
        void AddByIndex(T item, int index);
        void Add(T item);
    }
}
