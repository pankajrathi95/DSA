/*
https://www.hackerrank.com/challenges/insert-a-node-at-the-tail-of-a-linked-list/problem
*/

public class InsertANodeAtTheTail
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

    public static SinglyLinkedListNode InsertNodeAtTail(SinglyLinkedListNode head, int data)
    {
        if (head == null)
        {
            return new SinglyLinkedListNode(data);
        }

        var current = head;
        while (current.next != null)
        {
            current = current.next;
        }

        current.next = new SinglyLinkedListNode(data);
        return head;
    }
}