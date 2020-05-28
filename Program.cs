using System;
using System.Collections.Generic;
using static MiddleLinkedList;

namespace DataStructures
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[][] queries = new int[3][];

            queries[0] = new int[] { 1, 2, 100 };
            queries[1] = new int[] { 2, 5, 100 };
            queries[2] = new int[] { 3, 4, 100 };

            ArrayManipulation.CalArrayManipulation(5, queries);
        }
    }
}
