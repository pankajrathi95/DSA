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

            RemoveDuplicateLetters removeDuplicateLetters = new RemoveDuplicateLetters();
            removeDuplicateLetters.RemoveTheDuplicateLetters("bbcaac");




            //end here
            watch.Stop();
            Console.WriteLine("Time Taken: " + watch.ElapsedMilliseconds + " ms");
        }
    }
}