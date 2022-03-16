using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class GenericStack<T> : IPushStack<T>, IPopStack<T>
    {
        private readonly int maxSize;
        private int index;
        private T[] items;

        public GenericStack(int maxSize = 10)
        {
            this.maxSize = maxSize;
            this.items = new T[maxSize];
            this.index = 0;
        }

        public int Count => index;

        public void Push(T item)
        {
            if (index >= maxSize)
            {
                throw new InvalidOperationException("Stack is full");
            }

            items[index++] = item;
        }

        public T Pop()
        {
            index--;

            if (index >= 0)
            {
                return items[index];
            }

            index = 0;
            throw new InvalidOperationException("Stack is empty");
        }

    }
}
