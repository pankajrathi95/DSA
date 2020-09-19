/*
Loop Detection: Given a circular linked list, implement an algorithm that returns the node at the begining of the loop.
DEFINITION
Circular linked list: A (corrupt) linked list in which a node's next pointer points to an earlier node, so as to make a loop in the linked list.
EXAMPLE
Input: A->B->C->D->E->C [the same C as earlier]
Output: C
*/

public class LoopDetection
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

    public static ListNode IsLoop(ListNode head)
    {
        if (head == null)
        {
            return null;
        }

        ListNode slow = head;
        ListNode fast = head;
        while (fast.next != null && fast.next.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
            if (slow == fast)
            {
                slow = head;
                while (true)
                {
                    if (slow == fast)
                    {
                        return slow;
                    }
                    slow = slow.next;
                    fast = fast.next;
                }
            }
        }

        return null;
    }
}