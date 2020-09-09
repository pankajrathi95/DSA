public class Partition
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public ListNode PartitionBasedOnValue(ListNode node, int x)
    {
        ListNode head = node;
        ListNode tail = node;
        while (node != null)
        {
            ListNode next = node.next;
            if (node.val < x)
            {
                node.next = head;
                head = node;
            }
            else
            {
                tail.next = node;
                tail = node;
            }

            node = next;
        }

        tail.next = null;
        return head;
    }
}