/*
#148 - https://leetcode.com/problems/sort-list/
Given the head of a linked list, return the list after sorting it in ascending order.

Follow up: Can you sort the linked list in O(n logn) time and O(1) memory (i.e. constant space)?

 

Example 1:


Input: head = [4,2,1,3]
Output: [1,2,3,4]
Example 2:


Input: head = [-1,5,3,4,0]
Output: [-1,0,3,4,5]
Example 3:

Input: head = []
Output: []
 

Constraints:

The number of nodes in the list is in the range [0, 5 * 104].
-105 <= Node.val <= 105
*/

public class SortList
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
    public ListNode SortTheList(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return head;
        }

        var slow = head;
        var fast = head;
        while (fast.next != null && fast.next.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        var mid = slow.next;
        slow.next = null;
        var left = SortTheList(head);
        var right = SortTheList(mid);

        var dummy = new ListNode();
        var current = dummy;
        while (left != null && right != null)
        {
            if (left.val < right.val)
            {
                current.next = left;
                left = left.next;
            }
            else
            {
                current.next = right;
                right = right.next;
            }

            current = current.next;
        }

        if (left != null)
        {
            current.next = left;
        }

        if (right != null)
        {
            current.next = right;
        }

        return dummy.next;
    }
}