using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Stack
    {
        private readonly int size;
        private int top = 0;
        private int[] stack;
        public Stack(int size)
        {
            this.size = size;
            stack = new int[size];
        }

        public void Push(int item)
        {
            if (IsStackFull())
            {
                throw new StackOverflowException("Stack is Full!");
            }

            stack[top++] = item;
        }

        public int Pop()
        {
            if (IsStackEmpty())
            {
                throw new InvalidProgramException("Stack is Empty!");
            }

            return stack[top--];
        }

        public bool IsStackEmpty()
        {
            return top == 0;
        }

        private bool IsStackFull()
        {
            return top == size;
        }

        public int Peek()
        {
            if (top == 0)
            {
                throw new InvalidProgramException();
            }

            return stack[top - 1];
        }
        public void Print()
        {
            Console.Write("[ ");
            for (int i = 0; i < top; i++)
            {
                Console.Write(stack[i] + " ");
            }
            Console.WriteLine("]");
        }

        public int Min()
        {
            int min = stack[0];
            for (int i = 1; i < top; i++)
            {
                if (min < stack[i])
                {
                    min = stack[i];
                }
            }

            return min;
        }
    }
}
