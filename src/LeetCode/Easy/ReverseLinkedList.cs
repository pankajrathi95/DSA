/*
https://leetcode.com/problems/reverse-linked-list/submissions/
*/

public class ReverseLinkedList
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
    public ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        ListNode current = head;

        while (current != null)
        {
            var currentTemp = current.next;
            current.next = prev;
            prev = current;
            current = currentTemp;
        }

        return prev;
    }
}