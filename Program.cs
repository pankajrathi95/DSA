using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!");
            DeleteMiddleNode.ListNode head = new DeleteMiddleNode.ListNode(1);
            head.next = new DeleteMiddleNode.ListNode(5);
            head.next.next = new DeleteMiddleNode.ListNode(9);
            head.next.next.next = new DeleteMiddleNode.ListNode(12);

            DeleteMiddleNode.DeleteNode(head.next, head);
        }
    }
}
