/*
https://www.hackerrank.com/challenges/print-the-elements-of-a-linked-list-in-reverse/problem
*/

using System;
using System.Collections.Generic;

public class PrintInReverse
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

    public static void reversePrint(SinglyLinkedListNode head)
    {
        if (head != null)
        {
            reversePrint(head.next);
            Console.WriteLine(head.data);
        }
    }
}