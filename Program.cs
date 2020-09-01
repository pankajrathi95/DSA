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
            Palindrome.ListNode head = new Palindrome.ListNode(1);
            head.next = new Palindrome.ListNode(5);
            head.next.next = new Palindrome.ListNode(5);
            head.next.next.next = new Palindrome.ListNode(1);

            Console.Write(Palindrome.IsPalindrome(head));
        }
    }
}
