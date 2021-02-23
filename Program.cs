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
            LongestWordinDictionaryThroughDeleting res = new LongestWordinDictionaryThroughDeleting();
            IList<string> words = new List<string>();
            words.Add("ale");
            words.Add("apple");
            words.Add("monkey");
            words.Add("plea");
            res.FindLongestWord("abpcplea", words);
            //end here
            watch.Stop();
            Console.WriteLine("Time Taken: " + watch.ElapsedMilliseconds + " ms");
        }
    }
}