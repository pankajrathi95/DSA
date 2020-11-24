/*
https://leetcode.com/problems/add-two-numbers-ii/
You are given two non-empty linked lists representing two non-negative integers. The most significant digit comes first and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.

Follow up:
What if you cannot modify the input lists? In other words, reversing the lists is not allowed.

Example:

Input: (7 -> 2 -> 4 -> 3) + (5 -> 6 -> 4)
Output: 7 -> 8 -> 0 -> 7
*/


using System.Collections.Generic;

public class AddTwoNumbersII
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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        Stack<int> s1 = new Stack<int>();
        Stack<int> s2 = new Stack<int>();
        ListNode ans = null;
        int carry = 0, sum = 0;
        while (l1 != null)
        {
            s1.Push(l1.val);
            l1 = l1.next;
        }

        while (l2 != null)
        {
            s2.Push(l2.val);
            l2 = l2.next;
        }

        while (s1.Count != 0 || s2.Count != 0)
        {
            sum = 0;
            if (s1.Count != 0)
            {
                int val = s1.Pop();
                sum += val;
            }

            if (s2.Count != 0)
            {
                int val = s2.Pop();
                sum += val;
            }

            sum = sum + carry;
            carry = sum / 10;
            ListNode temp = new ListNode(sum % 10);
            temp.next = ans;
            ans = temp;
        }

        if (carry > 0)
        {
            ListNode temp = new ListNode(carry);
            temp.next = ans;
            ans = temp;
        }

        return ans;
    }
}