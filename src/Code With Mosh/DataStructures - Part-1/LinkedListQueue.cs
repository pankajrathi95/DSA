using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class LinkedListQueue
    {
        public class Node
        {
            public int item;
            public Node next;

            public Node(int value)
            {
                this.item = value;
            }
        }

        private Node first;
        private Node last;

        public void Enqueue(int item)
        {
            var node = new Node(item);
            if (IsEmpty())
            {
                first = last = node;
            }
            else
            {
                last.next = node;
                last = node;
            }
        }

        public int Dequeue()
        {
            int value;
            if (IsEmpty())
            {
                throw new InvalidOperationException("Nothing to remove");
            }

            if (first == last)
            {
                value = first.item;
                first = last = null;
            }
            else
            {
                value = first.item;
                first = first.next;
            }

            return value;
        }

        public bool IsEmpty()
        {
            return first == null;
        }
    }
}
