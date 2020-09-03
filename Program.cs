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

            LargestTimeForGivenDigits digits = new LargestTimeForGivenDigits();
            digits.LargestTimeFromDigits(new int[] { 2, 0, 6, 6 });
        }
    }
}
