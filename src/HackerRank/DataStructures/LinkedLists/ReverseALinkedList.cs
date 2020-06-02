/*
https://www.hackerrank.com/challenges/reverse-a-linked-list/problem
*/

using System;
using System.Collections.Generic;

public class ReverseALinkedList
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

    public static SinglyLinkedListNode Reverse(SinglyLinkedListNode head)
    {
        var current = head;
        Stack<int> stack = new Stack<int>();
        while (current != null)
        {
            stack.Push(current.data);
            current = current.next;
        }
        head = current = new SinglyLinkedListNode(stack.Pop());
        while (stack.Count != 0)
        {
            current.next = new SinglyLinkedListNode(stack.Pop());
            current = current.next;
        }

        return head;
    }
}