using System;
using System.Collections.Generic;
using static MiddleLinkedList;

namespace DataStructures
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ReverseALinkedList.SinglyLinkedListNode node = new ReverseALinkedList.SinglyLinkedListNode(1);
            node.next = new ReverseALinkedList.SinglyLinkedListNode(2);
            node.next.next = new ReverseALinkedList.SinglyLinkedListNode(3);

            ReverseALinkedList.Reverse(node);
        }
    }
}
