using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Abstractions
{
    public interface ISwapTwoItems<in T>
    {
        void SwapByIndexes(int index1, int index2);       
    }
}
