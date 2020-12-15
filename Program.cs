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

            // DecodeString decodeString = new DecodeString();
            // decodeString.DecodeTheString("3[a]2[bc]");

            SquaresofaSortedArray removeDuplicatesFromSortedArrayII = new SquaresofaSortedArray();
            removeDuplicatesFromSortedArrayII.SortedSquares(new int[] { -4, -1, 0, 3, 10 });

            //end here
            watch.Stop();
            Console.WriteLine("Time Taken: " + watch.ElapsedMilliseconds + " ms");
        }
    }
}