/*
https://www.hackerrank.com/challenges/detect-whether-a-linked-list-contains-a-cycle/problem
*/

public class CycleDetection
{
    public class SinglyLinkedListNode
    {
        public int data;
        public SinglyLinkedListNode next;
        public SinglyLinkedListNode(int nodeData)
        {
            this.data = nodeData;
            this.next = null;
        }
    }

    public static bool HasCycle(SinglyLinkedListNode head)
    {
        var slow = head;
        var fast = head.next;

        if (slow == null || fast == null)
        {
            return false;
        }

        while (slow.next != null && fast.next != null && fast.next.next != null)
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