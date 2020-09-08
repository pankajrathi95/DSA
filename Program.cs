using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!");

            MinimalTree minimalTree = new MinimalTree();
            minimalTree.FindMinimalTree(new int[] { 1, 2, 3, 4, 5, 6 });
        }
    }
}
