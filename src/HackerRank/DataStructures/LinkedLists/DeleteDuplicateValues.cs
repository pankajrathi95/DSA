/*
https://www.hackerrank.com/challenges/delete-duplicate-value-nodes-from-a-sorted-linked-list/problem
*/

public class DeleteDuplicateValues
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

    public static SinglyLinkedListNode RemoveDuplicates(SinglyLinkedListNode head)
    {
        if (head == null || head.next == null) return head;
        var root = head;
        while (head.next != null)
        {
            if (head.data != head.next.data)
            {
                head = head.next;
            }
            else
            {
                head.next = head.next.next;
            }
        }
        return root;
    }

}