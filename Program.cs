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

            PalindromeLinkedList elements = new PalindromeLinkedList();

            PalindromeLinkedList.ListNode listNode = new PalindromeLinkedList.ListNode(1, new PalindromeLinkedList.ListNode(2, new PalindromeLinkedList.ListNode(3, new PalindromeLinkedList.ListNode(2, new PalindromeLinkedList.ListNode(1, null)))));
            bool x = elements.IsPalindrome(listNode);
        }
    }
}
