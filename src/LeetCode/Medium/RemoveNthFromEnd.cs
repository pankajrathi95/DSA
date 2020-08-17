/*
https://leetcode.com/problems/remove-nth-node-from-end-of-list
*/

public class RemoveNthFromEnd
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
    public ListNode RemoveTheNthFromEnd(ListNode head, int n)
    {
        if (head == null || head.next == null)
        {
            return null;
        }

        var start = head;
        var end = head;
        while (end.next != null)
        {
            if (n <= 0)
            {
                start = start.next;
            }

            n--;
            end = end.next;
        }

        if (start == head && n > 0)
        {
            return head.next;
        }

        if (start == end)
        {
            start = null;
            return head;
        }

        start.next = start.next.next;
        return head;
    }
}