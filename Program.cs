using System;
using System.Diagnostics;
using Prototype;

namespace DataStructures
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!");
            var watch = new Stopwatch();
            watch.Start();
            //start here    

            LongestIncreasingPathinaMatrix lp = new LongestIncreasingPathinaMatrix();
            int[][] matrix = new int[3][];

            matrix[0] = new int[] { 3, 4, 5 };
            matrix[1] = new int[] { 3, 2, 6 };
            matrix[2] = new int[] { 2, 2, 1 };
            int count = lp.LongestIncreasingPath(matrix);
            //end here
            watch.Stop();
            Console.WriteLine("Time Taken: " + watch.ElapsedMilliseconds + " ms");
        }
    }
}