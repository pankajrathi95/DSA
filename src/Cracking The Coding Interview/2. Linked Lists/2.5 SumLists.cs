/*
Similar to this leetcode problem : https://leetcode.com/problems/add-two-numbers/
*/

public class SumLists
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
    public static ListNode AddTheTwoNumbers(ListNode l1, ListNode l2)
    {
        int carry = 0;
        var head = new ListNode();
        var current = head;
        while (l1 != null && l2 != null)
        {
            current.next = new ListNode((l1.val + l2.val) % 10 + carry);
            carry = (l1.val + l2.val) / 10;
            if (l1.next == null && l2.next != null)
            {
                current = current.next;
                l2.next.val += carry;
                current.next = l2.next;
                break;
            }
            else if (l1.next != null && l2.next == null)
            {
                current = current.next;
                l1.next.val += carry;
                current.next = l1.next;
                break;
            }

            current = current.next;
            l1 = l1.next;
            l2 = l2.next;
        }

        return head.next;
    }
}