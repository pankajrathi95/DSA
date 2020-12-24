/*
#24 - https://leetcode.com/problems/swap-nodes-in-pairs/

Given a linked list, swap every two adjacent nodes and return its head.

You may not modify the values in the list's nodes. Only nodes itself may be changed.

 

Example 1:


Input: head = [1,2,3,4]
Output: [2,1,4,3]
Example 2:

Input: head = []
Output: []
Example 3:

Input: head = [1]
Output: [1]
 

Constraints:

The number of nodes in the list is in the range [0, 100].
0 <= Node.val <= 100
*/

/**
 * Definition for singly-linked list.
 * 
 */
public class SwapNodesinPairs
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
    public ListNode SwapPairs(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return head;
        }
        int k = 2;
        var current = head;
        int size = 0;
        while (current != null)
        {
            size++;
            current = current.next;
        }

        current = head;
        var tail1 = head;
        ListNode result = Reverse(ref current, k);
        // We will call the first reverse of k group manually to store the result in it. 
        //This will be the starting point of complete list 
        size = size - k;
        var tail2 = current;
        //this while loop run for k groups and stop if there are any elements less than k.
        //once the get the reversed list we have the tail1 (which is tail of prev group). we assign this to start of current group.
        //now assign tail1  to tail2 and tail2 to current.
        while (size >= k)
        {
            tail1.next = Reverse(ref current, k);
            tail1 = tail2;
            tail2 = current;
            size = size - k;
        }

        tail1.next = current;
        return result;
    }

    //This function would just reverse the linkedlist of k elements.
    private ListNode Reverse(ref ListNode current, int k)
    {
        ListNode ans = null;
        while (k != 0)
        {
            var nextNode = current.next;
            current.next = ans;
            ans = current;
            current = nextNode;
            k--;
        }

        return ans;
    }
}