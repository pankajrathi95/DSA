/*
Remove all elements from a linked list of integers that have value val.

Example:

Input: 1->2->6->3->4->5->6, val = 6
Output: 1->2->3->4->5
*/

/**
 * Definition for singly-linked list.

 */
public class RemoveLinkedListElements
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
    public ListNode RemoveElements(ListNode head, int val)
    {
        if (head == null)
        {
            return head;
        }

        while (head != null && head.val == val)
        {
            if (head.next == null)
            {
                head = null;
            }
            else
            {
                head = head.next;
            }
        }

        if (head == null)
        {
            return head;
        }

        var current = head;
        while (current.next != null)
        {
            if (current.next.val == val)
            {
                if (current.next.next != null)
                {
                    current.next = current.next.next;
                }
                else
                {
                    current.next = null;
                }
            }
            else
            {
                current = current.next;
            }
        }

        return head;
    }
}