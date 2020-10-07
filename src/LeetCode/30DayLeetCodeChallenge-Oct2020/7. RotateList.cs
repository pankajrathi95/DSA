/*
Given a linked list, rotate the list to the right by k places, where k is non-negative.

Example 1:

Input: 1->2->3->4->5->NULL, k = 2
Output: 4->5->1->2->3->NULL
Explanation:
rotate 1 steps to the right: 5->1->2->3->4->NULL
rotate 2 steps to the right: 4->5->1->2->3->NULL
Example 2:

Input: 0->1->2->NULL, k = 4
Output: 2->0->1->NULL
Explanation:
rotate 1 steps to the right: 2->0->1->NULL
rotate 2 steps to the right: 1->2->0->NULL
rotate 3 steps to the right: 0->1->2->NULL
rotate 4 steps to the right: 2->0->1->NULL
*/

public class RotateList
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
    public ListNode RotateRight(ListNode head, int k)
    {
        if (head == null)
        {
            return null;
        }

        var current = head;
        int length = 0;
        var slow = head;
        while (current != null)
        {
            length++;
            current = current.next;
        }

        k = k % length;
        current = head;
        while (current.next != null)
        {
            if (k <= 0)
            {
                current = current.next;
                slow = slow.next;
            }
            else
            {
                current = current.next;
            }

            k--;
        }

        current.next = head;
        head = slow.next;
        slow.next = null;

        return head;
    }
}