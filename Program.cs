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

            MaximumPointsYouCanObtainFromCards maximumPointsYouCanObtainFromCards = new MaximumPointsYouCanObtainFromCards();
            maximumPointsYouCanObtainFromCards.MaxScore(new int[] { 96, 90, 41, 82, 39, 74, 64, 50, 30 }, 8);

            //end here
            watch.Stop();
            Console.WriteLine("Time Taken: " + watch.ElapsedMilliseconds + " ms");
        }
    }
}