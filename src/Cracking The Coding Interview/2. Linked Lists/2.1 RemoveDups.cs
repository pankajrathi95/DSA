using System.Collections.Generic;

public class RemoveDups
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
    //using extra space (HashSet)
    public static ListNode RemoveDuplicate(ListNode head)
    {
        if (head == null)
        {
            return null;
        }

        HashSet<int> values = new HashSet<int>();
        var current = head;
        ListNode prev = null;
        while (current != null)
        {
            if (!values.Contains(current.val))
            {
                values.Add(current.val);
                prev = current;
            }
            else
            {
                prev.next = current.next;
            }

            current = current.next;
        }

        return head;
    }

    //With no extra space. 
    public static ListNode RemoveDuplicates(ListNode head)
    {
        var current = head;
        while (current != null)
        {
            var nextElement = current;
            while (nextElement.next != null)
            {
                if (nextElement.next.val == current.val)
                {
                    nextElement.next = nextElement.next.next;
                }
                else
                {
                    nextElement = nextElement.next;
                }
            }

            current = current.next;
        }

        return head;
    }
}