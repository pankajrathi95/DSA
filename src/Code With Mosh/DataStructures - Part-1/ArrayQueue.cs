using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class ArrayQueue
    {
        private int[] queue;
        private int front;
        private int back;
        private int count;

        public ArrayQueue(int size)
        {
            queue = new int[size];
            front = 0;
            back = 0;
        }

        public void Enqueue(int item)
        {
            if (count == queue.Length)
            {
                throw new InsufficientMemoryException("Queue is Full!");
            }

            queue[back] = item;
            back = (back + 1) % queue.Length;
            count++;
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new Exception("Queue is Empty!");
            }
            var item = queue[front];
            count--;
            front = (front + 1) % queue.Length;
            return item;
        }

        private bool IsFull()
        {
            return back == queue.Length;
        }

        private bool IsEmpty()
        {
            return front == -1;
        }

        public int Peek()
        {
            return queue[back];
        }
    }
}
