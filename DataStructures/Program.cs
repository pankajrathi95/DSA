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
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Insert(10);
            binaryTree.Insert(15);
            binaryTree.Insert(9);
            binaryTree.Insert(12);
        }
    }
}
