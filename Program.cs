using System;
using System.Diagnostics;
using Prototype;

namespace DataStructures
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!");
            var watch = new Stopwatch();
            watch.Start();
            //start here

            SearchInRotatedSortedArray searchInRotatedSortedArray = new SearchInRotatedSortedArray();
            searchInRotatedSortedArray.Search(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0);

            //end here
            watch.Stop();
            Console.WriteLine("Time Taken: " + watch.ElapsedMilliseconds + " ms");
        }
    }
}