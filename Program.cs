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

            RemoveDuplicatesFromSortedArrayII removeDuplicatesFromSortedArrayII = new RemoveDuplicatesFromSortedArrayII();
            removeDuplicatesFromSortedArrayII.RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 });

            //end here
            watch.Stop();
            Console.WriteLine("Time Taken: " + watch.ElapsedMilliseconds + " ms");
        }
    }
}