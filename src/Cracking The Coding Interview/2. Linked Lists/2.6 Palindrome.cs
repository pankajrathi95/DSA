/*

*/

using System.Collections.Generic;

public class Palindrome
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
    public static bool IsPalindrome(ListNode head)
    {
        Stack<int> stack = new Stack<int>();
        var current = head;
        while (current != null)
        {
            stack.Push(current.val);
            current = current.next;
        }

        current = head;
        while (current != null)
        {
            if (stack.Pop() != current.val)
            {
                return false;
            }

            current = current.next;
        }

        return true;
    }
}