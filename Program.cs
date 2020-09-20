using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

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
            int[][] grid = new int[3][];
            grid[0] = new int[] { 1, 0, 0, 0 };
            grid[1] = new int[] { 0, 0, 0, 0 };
            grid[2] = new int[] { 0, 0, 0, 2 };
            UniquePathsIII uniquePathsIII = new UniquePathsIII();
            uniquePathsIII.FindUniquePaths(grid);

            //end here
            watch.Stop();
            Console.WriteLine("Time Taken: " + watch.ElapsedMilliseconds + " ms");
        }
    }
}