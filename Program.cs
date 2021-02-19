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
            int[][] grid = new int[][]
            {
                new int[] { 1, 1, 0, 0, 0 },
                new int[] { 1, 1, 0, 0, 0 },
                new int[] { 0, 0, 0, 1, 1 },
                new int[] { 0, 0, 0, 1, 1 }
            };



            MaxAreaOfIsland max = new MaxAreaOfIsland();



            max.MaxAreaOfIslands(grid);
            //end here
            watch.Stop();
            Console.WriteLine("Time Taken: " + watch.ElapsedMilliseconds + " ms");
        }
    }
}