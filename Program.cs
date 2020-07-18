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

            TopKFrequentElements elements = new TopKFrequentElements();
            int[] values = elements.TopKFrequent(new int[] { 1, 1, 1, 2, 2, 3 }, 2);
        }
    }
}
