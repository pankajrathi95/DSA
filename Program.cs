using System;
using System.Collections.Generic;
using static MiddleLinkedList;

namespace DataStructures
{
    class Program
    {
        public static void Main(string[] args)
        {
            MaximumSumCircularSubarray circularSubarray = new MaximumSumCircularSubarray();
            circularSubarray.MaxSubarraySumCircular(new int[] { 5, -3, 5 });
        }
    }
}
