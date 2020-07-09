/*
https://leetcode.com/problems/linked-list-cycle/submissions/
*/

/**
 * Definition for singly-linked list.
 * 
 */
public class LinkedListCycle
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
    public bool HasCycle(ListNode head)
    {

        if (head == null || head.next == null)
        {
            return false;
        }
        ListNode fast = head.next;
        ListNode slow = head;
        while (fast != slow)
        {
            if (fast == null || fast.next == null)
            {
                return false;
            }

            fast = fast.next.next;
            slow = slow.next;
        }

        return true;
    }
}