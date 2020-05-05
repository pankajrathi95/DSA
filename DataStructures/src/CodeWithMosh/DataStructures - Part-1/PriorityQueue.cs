using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    class PriorityQueue
    {
        private int[] queue;
        private readonly int size;
        private int top = 0;
        public PriorityQueue(int size)
        {
            this.size = size;
            queue = new int[size];
        }

        public void Enqueue(int item)
        {
            if (top == size)
            {
                throw new InvalidOperationException("Queue is Full!");
            }
            else if (top == 0)
            {
                queue[top++] = item;
            }
            else
            {
                int iterator = top;
                while (item <= queue[iterator - 1])
                {
                    queue[iterator] = queue[iterator - 1];
                    iterator--;
                }
                queue[iterator] = item;
                top++;
            }
        }

        public int Dequeue()
        {
            if (top == 0)
            {
                throw new InvalidOperationException("Queue is empty!");
            }

            return queue[--top];
        }

        public void Print()
        {
            for (int i = 0; i < top; i++)
            {
                Console.Write(queue[i] + " ");
            }
        }
    }
}
