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
            // ReorderList.ListNode head =
            // new ReorderList.ListNode(1,
            // new ReorderList.ListNode(2,
            // new ReorderList.ListNode(3,
            // new ReorderList.ListNode(4,
            // new ReorderList.ListNode(5,
            // new ReorderList.ListNode(6,
            // new ReorderList.ListNode(7,
            // null)))))));

            // ReorderList reorderList = new ReorderList();
            // reorderList.ReorderTheList(head);

            Console.WriteLine(StringCompression.CompressString("aabcccccaaa"));
            Console.WriteLine(OneAway.FindIfOneWay("pales", "pale"));
            Console.WriteLine(OneAway.FindIfOneWay("pale", "bale"));
            Console.WriteLine(OneAway.FindIfOneWay("pake", "bake"));
        }
    }
}
