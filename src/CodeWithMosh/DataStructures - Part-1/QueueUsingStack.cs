using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class QueueUsingStack
    {
        private Stack<int> stack1;
        private Stack<int> stack2;
        private readonly int size;

        public QueueUsingStack(int size)
        {
            stack1 = new Stack<int>(size);
            stack2 = new Stack<int>(size);
            this.size = size;
        }

        public void Enqueue(int number)
        {
            if (stack1.Count == size)
            {
                throw new StackOverflowException("Stack1 is full!");
            }

            if (stack2.Count == size)
            {
                throw new StackOverflowException("Stack2 is full!");
            }

            stack1.Push(number);
        }

        public int Dequeue()
        {
            if (stack2.Count == 0)
            {
                while (stack1.Count != 0)
                {
                    stack2.Push(stack1.Pop());
                }
            }

            return stack2.Pop();
        }
    }
}
