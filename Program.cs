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

            string s = "|**|*|*****|***||**|**|*";
            int[] startIndices = new int[] { 1, 4, 1, 6, 3, 1 };
            int[] endIndices = new int[] { 5, 6, 6, 10, 15, 24 };




            //end here
            watch.Stop();
            Console.WriteLine("Time Taken: " + watch.ElapsedMilliseconds + " ms");
        }
    }
}