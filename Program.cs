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
            string[] words = new string[] { "ab", "cb", "ad", "bd", "ac", "ca", "da", "bc", "db", "adcb", "dabc", "abb", "acb" };
            char[][] board = new char[2][];
            board[0] = new char[] { 'a', 'b' };
            board[1] = new char[] { 'c', 'd' };
            WordSearchII wordSearchII = new WordSearchII();
            wordSearchII.FindWords(board, words);

            //end here
            watch.Stop();
            Console.WriteLine("Time Taken: " + watch.ElapsedMilliseconds + " ms");
        }
    }
}