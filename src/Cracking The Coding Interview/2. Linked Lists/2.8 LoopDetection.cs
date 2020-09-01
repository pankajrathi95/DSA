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

    public static bool IsLoop(ListNode head)
    {
        var slow = head;
        var fast = head.next;

        while (fast.next != null && fast.next.next != null)
        {
            if (slow == fast)
            {
                return true;
            }

            slow = slow.next;
            fast = fast.next.next;
        }

        return false;
    }
}