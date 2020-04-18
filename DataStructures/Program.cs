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
            MinimumPathSum minimumPathSum = new MinimumPathSum();
            int[][] array = new int[3][];

            array[0] = new int[] { 1, 3, 1 };
            array[1] = new int[] { 1, 5, 1 };
            array[2] = new int[] { 4, 2, 1 };
            minimumPathSum.MinPathSum(array);
        }
    }
}
