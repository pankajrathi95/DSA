using System;
using System.Collections.Generic;
using static MiddleLinkedList;

namespace DataStructures
{
    class Program
    {
        public static void Main(string[] args)
        {
            OddEvenLinkedList evenLinkedList = new OddEvenLinkedList();
            OddEvenLinkedList.ListNode head = new OddEvenLinkedList.ListNode(1, new OddEvenLinkedList.ListNode(2, new OddEvenLinkedList.ListNode(3, new OddEvenLinkedList.ListNode(4, new OddEvenLinkedList.ListNode(5, null)))));
            evenLinkedList.OddEvenList(head);
        }
    }
}
