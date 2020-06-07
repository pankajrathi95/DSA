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

            DeleteDuplicateValues.SinglyLinkedListNode node = new DeleteDuplicateValues.SinglyLinkedListNode(3);
            node.next = new DeleteDuplicateValues.SinglyLinkedListNode(3);
            node.next.next = new DeleteDuplicateValues.SinglyLinkedListNode(3);
            node.next.next.next = new DeleteDuplicateValues.SinglyLinkedListNode(4);
            node.next.next.next.next = new DeleteDuplicateValues.SinglyLinkedListNode(5);
            node.next.next.next.next.next = new DeleteDuplicateValues.SinglyLinkedListNode(5);


            //var nodeF = DeleteDuplicateValues.RemoveDuplicates(node);
        }
    }
}
