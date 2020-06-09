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

            // DeleteDuplicateValues.SinglyLinkedListNode node = new DeleteDuplicateValues.SinglyLinkedListNode(3);
            // node.next = new DeleteDuplicateValues.SinglyLinkedListNode(3);
            // node.next.next = new DeleteDuplicateValues.SinglyLinkedListNode(3);
            // node.next.next.next = new DeleteDuplicateValues.SinglyLinkedListNode(4);
            // node.next.next.next.next = new DeleteDuplicateValues.SinglyLinkedListNode(5);
            // node.next.next.next.next.next = new DeleteDuplicateValues.SinglyLinkedListNode(5);


            //var nodeF = DeleteDuplicateValues.RemoveDuplicates(node);


            ReverseADoublyLinkedList.DoublyLinkedListNode node1 = new ReverseADoublyLinkedList.DoublyLinkedListNode(1);
            ReverseADoublyLinkedList.DoublyLinkedListNode node2 = new ReverseADoublyLinkedList.DoublyLinkedListNode(2);
            ReverseADoublyLinkedList.DoublyLinkedListNode node3 = new ReverseADoublyLinkedList.DoublyLinkedListNode(3);
            ReverseADoublyLinkedList.DoublyLinkedListNode node4 = new ReverseADoublyLinkedList.DoublyLinkedListNode(4);

            node1.next = node2;
            node2.prev = node1;

            node2.next = node3;
            node3.prev = node2;

            node3.next = node4;
            node4.prev = node3;

            var node = ReverseADoublyLinkedList.Reverse(node1);
        }
    }
}
