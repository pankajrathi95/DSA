using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    class QueueReverser
    {
        public static int[] Reverse(Queue<int> queue, int k)
        {
            Stack<int> stack = new Stack<int>();

            //dequeue the queue till k items and push into the stack
            for (int i = 0; i < k; i++)
            {
                stack.Push(queue.Dequeue());
            }

            //Enqueue the content from the stack back to queue
            while (stack.Count != 0)
            {
                queue.Enqueue(stack.Pop());
            }

            //removing the items after K and adding them at the end.

            for (int i = 0; i < queue.Count - k; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }

            return queue.ToArray();
        }
    }
}
