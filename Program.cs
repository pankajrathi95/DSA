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

            LoopDetection.ListNode head = new LoopDetection.ListNode(1);
            head.next = new LoopDetection.ListNode(0);
            head.next.next = new LoopDetection.ListNode(13);
            head.next.next.next = new LoopDetection.ListNode(8);
            head.next.next.next.next = new LoopDetection.ListNode(3);
            head.next.next.next.next.next = new LoopDetection.ListNode(4);
            head.next.next.next.next.next.next = new LoopDetection.ListNode(6);
            head.next.next.next.next.next.next.next = head.next.next.next;

            LoopDetection.IsLoop(head);
        }
    }
}
