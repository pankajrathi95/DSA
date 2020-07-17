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

            SelectionSort bubbleSort = new SelectionSort();
            int[] array = new int[] { 2, 5, 3, 1, 4 };
            bubbleSort.Sort(array);
            Console.WriteLine(String.Join(",", array.Select(p => p.ToString()).ToArray()));
        }
    }
}
