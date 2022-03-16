using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.Abstractions;

namespace Assignment
{
    public class GenericCollection<T> : IGetItemByIndex<T>, ISetItemByIndex<T>, ISwapTwoItems<T>
    {
        private readonly int maxsize;
        public T[] items;
        public int index;    

        public GenericCollection(int maxSize = 10)
        {
            this.maxsize = maxSize;
            this.items = new T[maxsize];
            index = 0;
        }

        public void Add(T item)
        {
            if (index >= maxsize)
                throw new ArgumentOutOfRangeException("Array is full");

            items[index++] = item;
        }

        public void AddByIndex(T item, int index)
        {
            
            items[index] = item;
        }

        public T GetItemByIndex(int index)
        {
            if (index >= maxsize)
                throw new ArgumentOutOfRangeException("Index out of bounds");

            return items[index];
        }

        public void SwapByIndexes(int index1, int index2)
        {
            if(index1 >= maxsize || index2 >= maxsize)
                throw new ArgumentOutOfRangeException("Index out of bounds");

            T aux;
            aux = this.items[index1];
            this.items[index1] = this.items[index2];
            this.items[index2] = aux;
            
        }
   
        public void DisplayItems()
        {
            foreach(T item in items)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
