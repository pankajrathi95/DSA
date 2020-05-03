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

            RansomNote ransom = new RansomNote();
            ransom.CanConstruct("aa", "ab");
        }
    }
}
