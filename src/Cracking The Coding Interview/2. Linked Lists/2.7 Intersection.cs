/*
Problem Statement:
Given two (singly) linked lists, determine if the two lists intersect. Return the intersecting node. Note that the intersection is
defined based on reference, not value. That is, if the kth node of the first linked list is the exact same node (by reference) as the
jth node of the secondlinked list, then they are intersecting.
*/

using System;

public class Intersection
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public static ListNode IntersectionOfTwoLists(ListNode l1, ListNode l2)
    {
        int length1 = 0, length2 = 0;
        var current = l1;
        ListNode tail1 = null, tail2 = null;
        while (current != null)
        {
            length1++;
            tail1 = current;
            current = current.next;
        }

        current = l2;
        while (current != null)
        {
            length2++;
            tail2 = current;
            current = current.next;
        }

        if (tail1 != tail2)
        {
            return null;
        }

        ListNode longer = length2 > length1 ? l2 : l1;
        ListNode shorter = length2 > length1 ? l1 : l2;

        int diff = Math.Abs(length1 - length2);
        while (diff > 0)
        {
            longer = longer.next;
            diff--;
        }

        while (longer != null)
        {
            if (longer == shorter)
            {
                return shorter;
            }

            longer = longer.next;
            shorter = shorter.next;
        }

        return null;
    }
}