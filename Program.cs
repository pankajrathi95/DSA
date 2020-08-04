using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddTwoNumbers.ListNode l1 = new AddTwoNumbers.ListNode(2, new AddTwoNumbers.ListNode(4, new AddTwoNumbers.ListNode(3, new AddTwoNumbers.ListNode(6, new AddTwoNumbers.ListNode(9)))));
            AddTwoNumbers.ListNode l2 = new AddTwoNumbers.ListNode(5, new AddTwoNumbers.ListNode(6, new AddTwoNumbers.ListNode(4)));
            AddTwoNumbers addTwoNumbers = new AddTwoNumbers();
            addTwoNumbers.AddTheTwoNumbers(l1, l2);
        }
    }
}
