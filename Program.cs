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
            int[][] val = new int[3][];
            val[0] = new int[] { 3, 4 };
            val[1] = new int[] { 2, 3 };
            val[2] = new int[] { 1, 2 };

            FindRightInterval find = new FindRightInterval();
            find.FindInterval(val);
        }
    }
}
