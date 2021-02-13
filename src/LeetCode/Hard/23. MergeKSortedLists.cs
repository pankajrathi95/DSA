/*
https://leetcode.com/problems/merge-k-sorted-lists/
You are given an array of k linked-lists lists, each linked-list is sorted in ascending order.

Merge all the linked-lists into one sorted linked-list and return it.

 

Example 1:

Input: lists = [[1,4,5],[1,3,4],[2,6]]
Output: [1,1,2,3,4,4,5,6]
Explanation: The linked-lists are:
[
  1->4->5,
  1->3->4,
  2->6
]
merging them into one sorted list:
1->1->2->3->4->4->5->6
Example 2:

Input: lists = []
Output: []
Example 3:

Input: lists = [[]]
Output: []
 

Constraints:

k == lists.length
0 <= k <= 10^4
0 <= lists[i].length <= 500
-10^4 <= lists[i][j] <= 10^4
lists[i] is sorted in ascending order.
The sum of lists[i].length won't exceed 10^4.
*/

using System;

public class MergeKSortedLists
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
    public ListNode MergeKLists(ListNode[] lists)
    {
        if (lists.Length == 0)
        {
            return null;
        }

        ListNode head = lists[0];
        for (int i = 1; i < lists.Length; i++)
        {
            head = MergeTwoLists(head, lists[i]);
        }

        return head;
    }

    private ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        ListNode fakeHead = new ListNode(0);
        var current = fakeHead;
        while (l1 != null && l2 != null)
        {
            if (l1.val >= l2.val)
            {
                current.next = l2;
                l2 = l2.next;
            }
            else
            {
                current.next = l1;
                l1 = l1.next;
            }

            current = current.next;
        }

        if (l1 == null)
        {
            current.next = l2;
        }
        else
        {
            current.next = l1;
        }

        return fakeHead.next;
    }
}