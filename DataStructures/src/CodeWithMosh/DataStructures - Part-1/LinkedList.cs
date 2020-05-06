using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class LinkedList
    {
        public class Node
        {
            public int value;
            public Node next;

            public Node(int value)
            {
                this.value = value;
            }
        }

        private Node first;
        private Node last;
        private int size;

        public bool isEmpty()
        {
            return first == null;
        }

        public Node GetPrevious(Node node)
        {
            var current = first;
            while (current != null)
            {
                if (current.next == node)
                {
                    return current;
                }
                current = current.next;
            }
            return null;
        }

        public int Size()
        {
            return size;
        }

        //AddFirst
        public void AddFirst(int number)
        {
            var node = new Node(number);

            if (isEmpty())
            {
                first = last = node;
            }
            else
            {
                node.next = first;
                first = node;
            }

        }

        //AddLast
        public void AddLast(int number)
        {
            var node = new Node(number);

            if (isEmpty())
            {
                first = last = node;
            }
            else
            {
                last.next = node;
                last = node;
            }
            size++;
        }

        //DeleteFirst
        public void DeleteFirst()
        {
            if (isEmpty())
            {
                Console.WriteLine("LinkedList is empty!");
                throw new Exception("Linkedlist is empty!");
            }

            if (first == last)
            {
                first = last = null;
            }
            else
            {
                first = first.next;
            }

            size--;
        }

        //DeleteLast
        public void DeleteLast()
        {
            if (isEmpty())
            {
                Console.WriteLine("LinkedList is empty!");
                throw new Exception("Linkedlist is empty!");
            }

            if (first == last)
            {
                first = last = null;
            }
            else
            {
                var previous = GetPrevious(last);
                last = previous;
                last.next = null;
            }

            size--;
        }

        //Contains
        public bool Contains(int number)
        {
            return IndexOf(number) != -1;
        }

        //IndexOf
        public int IndexOf(int number)
        {
            int index = 0;
            Node current = first;
            while (current != null)
            {
                if (current.value == number)
                {
                    return index;
                }
                current = current.next;
                index++;
            }

            return -1;
        }

        //ToArray
        public int[] ToArray()
        {
            int[] arr = new int[size];
            var current = first;
            for (int i = 0; i < size; i++)
            {
                arr[i] = current.value;
                current = current.next;
            }
            return arr;
        }

        //Reverse
        public void Reverse()
        {
            var previous = first;
            var current = first.next;
            while (current != null)
            {
                var next = current.next;
                current.next = previous;
                previous = current;
                current = next;
            }

            last = first;
            first = previous;
            last.next = null;
        }

        public int GetKthFromTheEnd(int k)
        {
            Node one = first;
            Node two = first.next;
            int distance = 1;

            if (one.next == null || k > size)
            {
                Console.WriteLine("Invalid Scenario");
                return -1;
            }

            if (two.next == null && k > 2)
            {
                Console.WriteLine("K should be less than 2");
                return -1;
            }
            while (two.next != null)
            {
                if (distance != k - 1)
                {
                    two = two.next;
                    distance++;
                }
                else
                {
                    one = one.next;
                    two = two.next;
                }
            }

            return one.value;
        }

        public void PrintMiddle()
        {
            Node node = first;
            Node middle = first;

            while (node != last && node.next != last)
            {
                middle = middle.next;
                node = node.next.next;
            }

            if (node == last)
            {
                Console.WriteLine(middle.value);
            }
            else
            {
                Console.WriteLine(middle.value + " and " + middle.next.value);
            }
        }

        public bool HasLoop()
        {
            Node slow = first;
            Node fast = first;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                {
                    return true;
                }
            }
            return false;
        }

        public static LinkedList CreateWithLoop()
        {
            var list = new LinkedList();
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);

            // Get a reference to 30
            var node = list.last;

            list.AddLast(40);
            list.AddLast(50);

            // Create the loop
            list.last.next = node;

            return list;
        }
    }
}
