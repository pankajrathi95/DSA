using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class StackWithTwoQueues
    {
        private int size = 0;
        private Queue<int> queue1 = new Queue<int>();
        private Queue<int> queue2 = new Queue<int>();

        public void Push(int item)
        {
            if (queue1.Count == 0)
            {
                queue2.Enqueue(item);
            }
            else
            {
                queue1.Enqueue(item);
            }
            size++;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is Empty");
            }

            //Instead of checking in which queue the data is and moving data from one queue to another.
            //We can also swap the queues once we done with the pop operation so that the data always 
            //stays in the first queue itself.
            if (queue1.Count == 0)
            {
                size--;
                return PopFromQueue(queue2, queue1);
            }
            else
            {
                size--;
                return PopFromQueue(queue1, queue2);
            }
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        private static int PopFromQueue(Queue<int> queue1, Queue<int> queue2)
        {
            int num = -1;
            while (queue1.Count != 0)
            {
                if (queue1.Count == 1)
                {
                    num = queue1.Dequeue();
                }
                else
                {
                    queue2.Enqueue(queue1.Dequeue());
                }
            }
            return num;
        }

        private static int PeekFromQueue(Queue<int> queue1, Queue<int> queue2)
        {
            int num = -1;
            while (queue1.Count != 0)
            {
                if (queue1.Count == 1)
                {
                    num = queue1.Peek();
                }

                queue2.Enqueue(queue1.Dequeue());
            }
            return num;
        }

        public int Size()
        {
            return size;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is Empty");
            }

            if (queue1.Count == 0)
            {
                return PeekFromQueue(queue2, queue1);
            }
            else
            {
                return PeekFromQueue(queue1, queue2);
            }
        }
    }
}
