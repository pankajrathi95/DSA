/*
https://www.hackerrank.com/challenges/insert-a-node-at-a-specific-position-in-a-linked-list/problem
*/

public class InsertANodeAtSpecificPosition
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

    public static SinglyLinkedListNode InsertNodeAtPosition(SinglyLinkedListNode head, int data, int position)
    {
        var current = head;

        for (int i = 1; i < position; i++)
        {
            current = current.next;
        }

        var nextNode = current.next;
        current.next = new SinglyLinkedListNode(data);
        current.next.next = nextNode;
        return head;
    }
}