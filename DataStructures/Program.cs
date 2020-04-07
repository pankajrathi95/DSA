using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CountingElements countingElements = new CountingElements();
            countingElements.CountElements(new int[] { 1, 1, 3, 3, 5, 5, 7, 7 });
        }
    }
}
