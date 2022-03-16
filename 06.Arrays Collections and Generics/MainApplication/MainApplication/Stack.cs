﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication
{
    public class Stack
    {
        private readonly int maxSize;
        private int index;
        private int[] items;

        public Stack(int maxSize = 10)
        {
            this.maxSize = maxSize;
            this.items = new int[maxSize];
            this.index = 0;
        }

        public void Push(int item)
        {
            if (index >= maxSize)
            {
                throw new InvalidOperationException("Stack is full");
            }

            items[index++] = item;
        }

        public int Pop()
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
