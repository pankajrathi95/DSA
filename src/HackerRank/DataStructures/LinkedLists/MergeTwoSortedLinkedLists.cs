/*
https://www.hackerrank.com/challenges/merge-two-sorted-linked-lists/problem
*/

public class MergeTwoSortedLinkedLists
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

    public static SinglyLinkedListNode MergeLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
    {
        if (head1 == null)
        {
            return head2;
        }
        else if (head2 == null)
        {
            return head1;
        }


        if (head1.data < head2.data)
        {
            head1.next = MergeLists(head1.next, head2);
            return head1;
        }
        else
        {
            head2.next = MergeLists(head2.next, head1);
            return head2;
        }
    }

}