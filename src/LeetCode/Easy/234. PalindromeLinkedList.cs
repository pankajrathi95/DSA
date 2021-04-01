/*
https://leetcode.com/problems/palindrome-linked-list/

Given the head of a singly linked list, return true if it is a palindrome.

 

Example 1:


Input: head = [1,2,2,1]
Output: true
Example 2:


Input: head = [1,2]
Output: false
 

Constraints:

The number of nodes in the list is in the range [1, 105].
0 <= Node.val <= 9
 

Follow up: Could you do it in O(n) time and O(1) space?
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

    //O(1) space
    public bool IsPalindrome(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return true;
        }

        var slow = head;
        var fast = head;
        while (fast.next != null && fast.next.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
        }

        ListNode res = Reverse(slow.next);
        while (res != null)
        {
            if (res.val != head.val)
            {
                return false;
            }

            res = res.next;
            head = head.next;
        }

        return true;
    }

    private ListNode Reverse(ListNode head)
    {
        ListNode prev = null;
        while (head != null)
        {
            var next = head.next;
            head.next = prev;
            prev = head;
            head = next;
        }

        return prev;
    }

    // O(n) space.
    public bool IsPalindrome2(ListNode head)
    {
        ListNode slow = head, fast = head;
        Stack<ListNode> stack = new Stack<ListNode>();
        while (fast != null)
        {
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
            if (stack.Pop().val != slow.val)
            {
                return false;
            }

            slow = slow.next;
        }

        return true;
    }
}