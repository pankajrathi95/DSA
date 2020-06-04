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

            MergeTwoSortedLinkedLists.SinglyLinkedListNode node = new MergeTwoSortedLinkedLists.SinglyLinkedListNode(1);
            node.next = new MergeTwoSortedLinkedLists.SinglyLinkedListNode(2);
            node.next.next = new MergeTwoSortedLinkedLists.SinglyLinkedListNode(3);

            MergeTwoSortedLinkedLists.SinglyLinkedListNode node1 = new MergeTwoSortedLinkedLists.SinglyLinkedListNode(3);
            node.next = new MergeTwoSortedLinkedLists.SinglyLinkedListNode(4);
            //node.next.next = new MergeTwoSortedLinkedLists.SinglyLinkedListNode(3);

            var nodeF = MergeTwoSortedLinkedLists.MergeLists(node, node1);
        }
    }
}
