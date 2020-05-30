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

            queries[0] = new int[] { 3, 3 };
            queries[1] = new int[] { 5, -1 };
            queries[2] = new int[] { -2, 4 };

            //ArrayManipulation.CalArrayManipulation(5, queries);

            KClosestPointsToOrigin origin = new KClosestPointsToOrigin();

            origin.KClosest(queries, 2);
        }
    }
}
