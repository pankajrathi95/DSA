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
            int[] nums = new int[] { 5, 9, 1, 3, 6, 0 };
            MergeSort merge = new MergeSort();
            merge.Sort(nums);
            Console.WriteLine(nums.ToList().ToString());
        }
    }
}
