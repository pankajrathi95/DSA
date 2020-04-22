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

            SubarraySumEqualsK subarray = new SubarraySumEqualsK();
            subarray.SubarraySum(new int[] { 1, 1, 1, -1, 2 }, 2);
        }
    }
}
