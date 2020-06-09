/*
https://www.hackerrank.com/challenges/find-the-merge-point-of-two-joined-linked-lists/problem
*/

public class FindMergePointOfTwoLists
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

    public static int FindMergeNode(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
    {
        while (head1 != null)
        {
            var current = head2;
            while (current != null)
            {
                if (current == head1)
                {
                    return current.data;
                }
                current = current.next;
            }

            head1 = head1.next;
        }

        return 0;

    }
}