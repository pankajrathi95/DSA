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

            // Console.WriteLine(tree.GetAncestors(81));

            // Heapify heapify = new Heapify();
            // int[] values = heapify.HeapifyIt(new int[] { 5, 3, 8, 4, 1, 2 });

            // Trie trie = new Trie();
            // trie.Insert("cat");
            // trie.Insert("calm");
            // trie.Remove("cat");
            // //Console.WriteLine(trie.Contains("ca"));
            // Console.WriteLine(trie.Contains("cat"));
            // //Console.WriteLine(trie.Contains("cal"));
            // Console.WriteLine(trie.Contains("calm"));
            // // trie.Traverse();
            int[][] values = new int[5][];

            values[0] = new int[2] { -4, -3 };
            values[1] = new int[2] { 1, 0 };
            values[2] = new int[2] { 3, -1 };
            values[3] = new int[2] { 0, -1 };
            values[4] = new int[2] { -5, 2 };
            CheckIfAStraightLine checkIfAStraightLine = new CheckIfAStraightLine();
            checkIfAStraightLine.CheckStraightLine(values);
        }
    }
}
