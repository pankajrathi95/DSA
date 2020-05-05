using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    class TwoStacks
    {
        private int[] twoStacks;
        private int top1;
        private int top2;
        public TwoStacks(int capacity)
        {
            if (capacity <= 0)
            {
                throw new InvalidProgramException("Size must be greater than Zero");
            }

            twoStacks = new int[capacity];
            top1 = -1;
            top2 = capacity;
        }

        public void Push1(int item)
        {
            if (IsFull1())
            {
                throw new InsufficientMemoryException("Stack1 is Full!");
            }

            twoStacks[top1++] = item;
        }

        public void Push2(int item)
        {
            if (IsFull2())
            {
                throw new InsufficientMemoryException("Stack2 is Full!");
            }

            twoStacks[--top1] = item;
        }

        public int Pop1()
        {
            if (IsEmpty1())
            {
                throw new Exception("Stack1 is empty!");
            }

            return twoStacks[top1--];
        }

        public int Pop2()
        {
            if (IsEmpty2())
            {
                throw new Exception("Stack2 is empty!");
            }

            return twoStacks[top2++];
        }

        public bool IsEmpty1()
        {
            return top1 == -1;
        }

        public bool IsEmpty2()
        {
            return top2 == twoStacks.Length;
        }
        public bool IsFull1()
        {
            return top1 + 1 == top2;
        }

        public bool IsFull2()
        {
            return top2 - 1 == top1;
        }
    }
}
