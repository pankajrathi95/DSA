/*

*/

public class ReturnKthtoLast
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
    public static ListNode KthNode(ListNode head, int k)
    {
        var current = head;
        while (k != 0)
        {
            if (current == null)
            {
                return null;
            }
            current = current.next;
            k--;
        }

        var result = head;
        while (current != null)
        {
            result = result.next;
            current = current.next;
        }

        return result;
    }
}