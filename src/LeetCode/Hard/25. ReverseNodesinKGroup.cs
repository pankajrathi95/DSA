/*
https://leetcode.com/problems/reverse-nodes-in-k-group/
Given a linked list, reverse the nodes of a linked list k at a time and return its modified list.

k is a positive integer and is less than or equal to the length of the linked list. If the number of nodes is not a multiple of k then left-out nodes, in the end, should remain as it is.

Follow up:

Could you solve the problem in O(1) extra memory space?
You may not alter the values in the list's nodes, only nodes itself may be changed.
 

Example 1:


Input: head = [1,2,3,4,5], k = 2
Output: [2,1,4,3,5]
Example 2:


Input: head = [1,2,3,4,5], k = 3
Output: [3,2,1,4,5]
Example 3:

Input: head = [1,2,3,4,5], k = 1
Output: [1,2,3,4,5]
Example 4:

Input: head = [1], k = 1
Output: [1]
 

Constraints:

The number of nodes in the list is in the range sz.
1 <= sz <= 5000
0 <= Node.val <= 1000
1 <= k <= sz
*/

public class ReverseNodesinKGroup
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
    public ListNode ReverseKGroup(ListNode head, int k)
    {
        if (k == 1 || head == null)
        {
            return head;
        }
        var current = head;
        int size = 0;
        while (current != null)
        {
            size++;
            current = current.next;
        }

        current = head;
        var tail1 = head;
        ListNode result = Reverse(ref current, k); // We will call the first reverse of k group manually to store the result in it. 
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