/*
https://leetcode.com/problems/palindrome-linked-list/
*/
using System.Collections.Generic;

public class PalindromeLinkedList
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
    public bool IsPalindrome(ListNode head)
    {
        ListNode slow = head, fast = head;
        Stack<ListNode> stack = new Stack<ListNode>();
        while (fast != null)
        {
            /*if (stack.Count != 0 && (fast.next == null || fast.next.next == null))
            {
                stack.Pop();
                break;
            }*/
            if (fast.next == null)
            {
                slow = slow.next;
                break;
            }

            stack.Push(slow);
            slow = slow.next;
            fast = fast.next.next;
        }

        while (stack.Count != 0)
        {
            if (stack.Pop() != slow)
            {
                return false;
            }

            slow = slow.next;
        }

        return true;
    }
}