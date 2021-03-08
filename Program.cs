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
            IList<string> wordList = new List<string>();
            wordList.Add("hot");
            wordList.Add("dog");
            wordList.Add("dot");
            wordList.Add("lot");
            wordList.Add("log");
            wordList.Add("cog");
            WordLadder game = new WordLadder();
            game.LadderLength("hit", "cog", wordList);
            //end here
            watch.Stop();
            Console.WriteLine("Time Taken: " + watch.ElapsedMilliseconds + " ms");
        }
    }
}