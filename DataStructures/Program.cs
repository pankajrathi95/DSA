using System;
using System.Collections.Generic;
using static MiddleLinkedList;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // BinaryTree tree = new BinaryTree();
            // tree.Insert(7);
            // tree.Insert(4);
            // tree.Insert(9);
            // tree.Insert(1);
            // tree.Insert(6);
            // tree.Insert(8);
            // tree.Insert(10);

            // tree.PrintNodesAtDistance(2);

            LeftmostColumn leftmost = new LeftmostColumn();
            int[][] array = new int[3][];

            array[0] = new int[] { 0, 0, 0, 1 };
            array[1] = new int[] { 0, 0, 1, 1 };
            array[2] = new int[] { 0, 1, 1, 1 };

            leftmost.LeftMostColumnWithOne(array);
        }
    }
}
