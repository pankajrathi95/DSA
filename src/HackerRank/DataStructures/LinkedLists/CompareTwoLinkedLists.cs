/*
https://www.hackerrank.com/challenges/compare-two-linked-lists/problem
*/

public class CompareTwoLinkedLists
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

    public static bool CompareLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
    {
        while (head1 != null && head2 != null)
        {
            if (head1.data != head2.data)
            {
                return false;
            }

            head1 = head1.next;
            head2 = head2.next;
        }

        if (head1 == null && head2 == null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}