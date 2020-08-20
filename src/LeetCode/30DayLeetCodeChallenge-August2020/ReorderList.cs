/*
Given a singly linked list L: L0→L1→…→Ln-1→Ln,
reorder it to: L0→Ln→L1→Ln-1→L2→Ln-2→…

You may not modify the values in the list's nodes, only nodes itself may be changed.

Example 1:

Given 1->2->3->4, reorder it to 1->4->2->3.
Example 2:

Given 1->2->3->4->5, reorder it to 1->5->2->4->3.
*/

using System.Collections.Generic;

public class ReorderList
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
    public void ReorderTheList(ListNode head)
    {
        if (head == null)
        {
            return;
        }

        if (head.next == null)
        {
            return;
        }
        Stack<ListNode> stack = new Stack<ListNode>();
        var current = head;
        ListNode slow = head, fast = head;
        bool flag = true;
        while (fast.next != null && fast.next.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        if (fast.next == null)
        {
            slow = slow.next;
            flag = false;
        }
        else
        {
            slow = slow.next.next;
        }

        while (slow != null)
        {
            stack.Push(slow);
            slow = slow.next;
        }

        current = head;
        var nextElement = head.next;
        while (stack.Count != 0)
        {
            current.next = stack.Pop();
            current.next.next = nextElement;

            current = nextElement;
            nextElement = current.next;
        }

        if (flag)
        {
            nextElement.next = null;
        }
        else
        {
            nextElement.next.next = null;
        }
    }
}