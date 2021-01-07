/*
#82 - https://leetcode.com/problems/remove-duplicates-from-sorted-list-ii/
Given the head of a sorted linked list, delete all nodes that have duplicate numbers, leaving only distinct numbers from the original list. Return the linked list sorted as well.

 

Example 1:


Input: head = [1,2,3,3,4,4,5]
Output: [1,2,5]
Example 2:


Input: head = [1,1,1,2,3]
Output: [2,3]
 

Constraints:

The number of nodes in the list is in the range [0, 300].
-100 <= Node.val <= 100
The list is guaranteed to be sorted in ascending order.
*/

public class RemoveDuplicatesFromSortedListII
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
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head == null) return null;
        ListNode fakeHead = new ListNode(0);
        fakeHead.next = head;
        var prev = fakeHead;
        var current = head;
        while (current != null)
        {
            while (current.next != null && current.val == current.next.val)
            {
                current = current.next;
            }

            if (prev.next == current)
            {
                prev = prev.next;
            }
            else
            {
                prev.next = current.next;
            }

            current = current.next;
        }

        return fakeHead.next;
    }
}