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
            ShapeClient.Run();
            //end here
            watch.Stop();
            Console.WriteLine("Time Taken: " + watch.ElapsedMilliseconds + " ms");
        }
    }
}