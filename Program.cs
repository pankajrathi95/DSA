using System;
using System.Collections.Generic;
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
            FruitIntoBasketss fruit = new FruitIntoBasketss();
            fruit.TotalFruit(new int[] { 3, 3, 3, 1, 2, 1, 1, 2, 3, 3, 4 });
            //end here
            watch.Stop();
            Console.WriteLine("Time Taken: " + watch.ElapsedMilliseconds + " ms");
        }
    }
}