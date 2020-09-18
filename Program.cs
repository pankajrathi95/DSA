using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

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

            RecursiveMultiply recursiveMultiply = new RecursiveMultiply();
            Console.WriteLine(recursiveMultiply.Multiply(8, 6));

            //end here
            watch.Stop();
            Console.WriteLine("Time Taken: " + watch.ElapsedMilliseconds + " ms");
        }
    }
}
