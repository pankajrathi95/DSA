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

            LongestMountaininArray longestMountaininArray = new LongestMountaininArray();
            longestMountaininArray.LongestMountain(new int[] { 2, 3, 3, 2, 0, 2 });


            //end here
            watch.Stop();
            Console.WriteLine("Time Taken: " + watch.ElapsedMilliseconds + " ms");
        }
    }
}