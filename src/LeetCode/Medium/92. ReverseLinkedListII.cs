/*
https://leetcode.com/problems/reverse-linked-list-ii/
Reverse a linked list from position m to n. Do it in one-pass.

Note: 1 ≤ m ≤ n ≤ length of list.

Example:

Input: 1->2->3->4->5->NULL, m = 2, n = 4
Output: 1->4->3->2->5->NULL
*/

public class ReverseLinkedListII
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
    public ListNode ReverseBetween(ListNode head, int m, int n)
    {
        if (head == null || m == n)
        {
            return head;
        }

        ListNode ans = null;
        var current = head;
        var temp = current;
        for (int i = 1; i < m; i++)
        {
            temp = current;
            current = current.next;
        }


        var tail = current;

        for (int i = m; i <= n; i++)
        {
            var nextNode = current.next;
            current.next = ans;
            ans = current;

            current = nextNode;
        }

        if (current == null && m == 1)
        {
            return ans;
        }
        else if (current == null && m != 1)
        {
            temp.next = ans;
            return head;
        }

        if (m == 1)
        {
            head.next = current;
            return ans;
        }

        tail.next = current;
        temp.next = ans;

        return head;
    }
}