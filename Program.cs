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

            MinimumDominoRotationsForEqualRow minimumDominoRotationsForEqualRow = new MinimumDominoRotationsForEqualRow();

            int[] A = new int[] { 1, 2, 1, 1, 1, 2, 2, 2 };
            int[] B = new int[] { 2, 1, 2, 2, 2, 2, 2, 2 };

            minimumDominoRotationsForEqualRow.MinDominoRotations(A, B);

            //end here
            watch.Stop();
            Console.WriteLine("Time Taken: " + watch.ElapsedMilliseconds + " ms");
        }
    }
}