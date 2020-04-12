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
            LastStoneWeight lastStoneWeight = new LastStoneWeight();
            lastStoneWeight.CalculateStoneWeight(new int[] { 2, 7, 4, 1, 8, 1 });
        }
    }
}
