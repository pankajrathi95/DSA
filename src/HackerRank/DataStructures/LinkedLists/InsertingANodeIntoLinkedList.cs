/*
https://www.hackerrank.com/challenges/reverse-a-doubly-linked-list/problem
*/

public class InsertingANodeIntoLinkedList
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

    public static DoublyLinkedListNode SortedInsert(DoublyLinkedListNode head, int data)
    {
        var current = head;
        if (head.data > data)
        {
            DoublyLinkedListNode node = new DoublyLinkedListNode(data);
            node.next = current;

            current.prev = node;
            return node;
        }

        while (current.next != null)
        {
            if (current.next.data > data && current.data <= data)
            {
                var temp = current.next;
                DoublyLinkedListNode node = new DoublyLinkedListNode(data);
                current.next = node;
                node.prev = current;

                node.next = temp;
                temp.prev = node;

                break;
            }

            current = current.next;
        }

        if (current.next == null)
        {
            DoublyLinkedListNode node = new DoublyLinkedListNode(data);

            current.next = node;
            node.prev = current;
        }


        return head;
    }
}