/*
https://www.hackerrank.com/challenges/insert-a-node-at-the-head-of-a-linked-list/problem
*/

public class InsertANodeAtTheHead
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

    public static SinglyLinkedListNode InsertNodeAtHead(SinglyLinkedListNode llist, int data)
    {
        var head = new SinglyLinkedListNode(data);
        head.next = llist;
        return head;
    }
}