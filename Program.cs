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
            // string[] words = new string[] { "ab", "cb", "ad", "bd", "ac", "ca", "da", "bc", "db", "adcb", "dabc", "abb", "acb" };
            // char[][] board = new char[2][];
            // board[0] = new char[] { 'a', 'b' };
            // board[1] = new char[] { 'c', 'd' };
            // WordSearchII wordSearchII = new WordSearchII();
            // wordSearchII.FindWords(board, words);

            LFUCache lFUCache = new LFUCache(2);
            lFUCache.Put(1, 1);
            lFUCache.Put(2, 2);
            lFUCache.Get(1);      // return 1
            lFUCache.Put(3, 3);   // evicts key 2
            lFUCache.Get(2);      // return -1 (not found)
            lFUCache.Get(3);      // return 3
            lFUCache.Put(4, 4);   // evicts key 1.
            lFUCache.Get(1);      // return -1 (not found)
            lFUCache.Get(3);      // return 3
            lFUCache.Get(4);      // return 4


            //end here
            watch.Stop();
            Console.WriteLine("Time Taken: " + watch.ElapsedMilliseconds + " ms");
        }
    }
}