/*
https://www.hackerrank.com/challenges/reverse-a-doubly-linked-list/problem
*/

public class ReverseADoublyLinkedList
{
    public class DoublyLinkedListNode
    {
        public int data;
        public DoublyLinkedListNode next;

        public DoublyLinkedListNode prev;
        public DoublyLinkedListNode(int nodeData)
        {
            this.data = nodeData;
            this.next = null;
            this.prev = null;
        }
    }

    public static DoublyLinkedListNode Reverse(DoublyLinkedListNode head)
    {
        var current = head;
        DoublyLinkedListNode newHead = null;
        while (current != null)
        {
            var temp = current.prev;
            current.prev = current.next;
            current.next = temp;

            newHead = current;
            current = current.prev;
        }

        return newHead;
    }
}