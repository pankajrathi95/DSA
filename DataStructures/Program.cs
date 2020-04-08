using System;
using static MiddleLinkedList;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MiddleLinkedList middleLinkedList = new MiddleLinkedList();
            MiddleLinkedList.ListNode listNode = new ListNode(1);
            listNode.next = new ListNode(2);
            listNode.next.next = new ListNode(3);
            listNode.next.next.next = new ListNode(4);
            listNode.next.next.next.next = new ListNode(5);

            var middle = middleLinkedList.MiddleNode(listNode);
        }
    }
}
