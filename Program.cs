using System;
using System.Collections.Generic;
using static MiddleLinkedList;

namespace DataStructures
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[][] A = new int[4][];
            A[0] = new int[] { 0, 2 };
            A[1] = new int[] { 5, 10 };
            A[2] = new int[] { 13, 23 };
            A[3] = new int[] { 24, 25 };

            int[][] B = new int[4][];
            B[0] = new int[] { 1, 5 };
            B[1] = new int[] { 8, 12 };
            B[2] = new int[] { 15, 24 };
            B[3] = new int[] { 25, 26 };
            IntervalListIntersections intersections = new IntervalListIntersections();
            int[][] C = intersections.IntervalIntersection(A, B);
        }
    }
}
