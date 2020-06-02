/*
https://www.hackerrank.com/challenges/delete-a-node-from-a-linked-list/problem
*/

public class DeleteANode
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

    public static SinglyLinkedListNode DeleteNode(SinglyLinkedListNode head, int position)
    {
        if (position == 0)
        {
            return head.next;
        }

        var current = head;

        for (int i = 0; i < position - 1; i++)
        {
            current = current.next;
        }

        current.next = current.next.next;
        return head;
    }
}