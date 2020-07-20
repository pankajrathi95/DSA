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

            RemoveLinkedListElements elements = new RemoveLinkedListElements();

            RemoveLinkedListElements.ListNode listNode = new RemoveLinkedListElements.ListNode(1, new RemoveLinkedListElements.ListNode(2, new RemoveLinkedListElements.ListNode(6, new RemoveLinkedListElements.ListNode(3, new RemoveLinkedListElements.ListNode(4, new RemoveLinkedListElements.ListNode(5, new RemoveLinkedListElements.ListNode(6, null)))))));
            var x = elements.RemoveElements(listNode, 6);
        }
    }
}
