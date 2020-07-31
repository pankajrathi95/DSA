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
            int[] nums = new int[] { 5, 7, 1, 3, 6, 0 };
            BucketSort merge = new BucketSort();
            merge.Sort(nums, 3);
            Console.WriteLine();

            ClimibingStairs climibing = new ClimibingStairs();
            Console.WriteLine(climibing.ClimbStairs(45));
        }
    }
}
