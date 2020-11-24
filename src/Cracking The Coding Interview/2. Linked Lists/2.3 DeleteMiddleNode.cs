/*
Problem Statement:
Implement an algorithm to delete a node in the middle(i.e., any node but the first and last node, not necessarily the exact middle)
of a singly linked list, given only access to tha node.
Example
Input: the node c from the linked list a->b->c->d->e->f
Result: nothing is returned, but the new linked list looks like a->b->d->e->f
*/

public class DeleteMiddleNode
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
    public static bool DeleteNode(ListNode node)
    {
        if (node == null || node.next == null)
        {
            return false;
        }

        var nextNode = node.next;
        node.val = nextNode.val;
        node.next = nextNode.next;
        return true;
    }
}