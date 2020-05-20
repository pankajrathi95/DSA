using System;
using System.Collections.Generic;
using static MiddleLinkedList;

namespace DataStructures
{
    class Program
    {
        public static void Main(string[] args)
        {
            MergeTwoSortedLists lists = new MergeTwoSortedLists();
            MergeTwoSortedLists.ListNode listNode1 = new MergeTwoSortedLists.ListNode(1, new MergeTwoSortedLists.ListNode(2, new MergeTwoSortedLists.ListNode(4, new MergeTwoSortedLists.ListNode(5, new MergeTwoSortedLists.ListNode(6)))));
            MergeTwoSortedLists.ListNode listNode2 = new MergeTwoSortedLists.ListNode(1, new MergeTwoSortedLists.ListNode(3, new MergeTwoSortedLists.ListNode(4, null)));
            lists.MergeTwoLists(listNode1, listNode2);
        }
    }
}
