
using System;



public class MergeTwoSortedLists
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
    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        ListNode res = new ListNode(0);
        ListNode current = res;
        while (true)
        {
            if (l1 == null)
            {
                current.next = l2;
                break;
            }

            if (l2 == null)
            {
                current.next = l1;
                break;
            }

            if (l1.val <= l2.val)
            {
                current.next = l1;
                l1 = l1.next;
            }
            else
            {
                current.next = l2;
                l2 = l2.next;
            }

            current = current.next;
        }

        return res.next;
    }
}