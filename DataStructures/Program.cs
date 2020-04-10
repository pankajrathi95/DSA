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
            NewYearChaos newYear = new NewYearChaos();
            newYear.MinimumBribes(new int[] { 1, 2, 5, 3, 7, 8, 6, 4 });
        }
    }
}
