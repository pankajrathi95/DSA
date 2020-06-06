/*
https://www.hackerrank.com/challenges/get-the-value-of-the-node-at-a-specific-position-from-the-tail/problem
*/

using System;
using System.Collections.Generic;

public class GetNodeValue
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

    public static int getNode(SinglyLinkedListNode head, int positionFromTail)
    {
        int size = 0;
        var current = head;

        while (current != null)
        {
            size++;
            current = current.next;
        }

        current = head;
        for (int i = 0; i < size - positionFromTail - 1; i++)
        {
            current = current.next;
        }

        return current.data;
    }
}