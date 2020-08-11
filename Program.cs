using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[][] grid = new int[3][];
            grid[0] = new int[] { 2, 1, 1 };
            grid[1] = new int[] { 1, 1, 0 };
            grid[2] = new int[] { 0, 1, 1 };
            RottingOranges rottingOranges = new RottingOranges();
            rottingOranges.OrangesRotting(grid);
        }
    }
}
