/*
https://leetcode.com/problems/intersection-of-two-linked-lists/
*/


using System.Collections.Generic;
public class IntersectionOfTwoLinkedLists
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        HashSet<ListNode> values = new HashSet<ListNode>();
        while (headA != null)
        {
            values.Add(headA);
            headA = headA.next;
        }

        while (headB != null)
        {
            if (values.Contains(headB))
            {
                return headB;
            }

            headB = headB.next;
        }

        return null;
    }
}