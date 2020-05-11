using System;
using System.Collections.Generic;
using static MiddleLinkedList;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Trie trie = new Trie();
            // trie.Insert("car");
            // trie.Insert("card");
            // trie.Insert("care");
            // trie.Insert("careful");
            // bool value = trie.ContainsRecursive("cars");
            // int count = trie.CountWords();
            // string tmep = Trie.LongestCommonPrefix(new string[] { "car", "card", "cardkdd" });

            int[][] image = new int[2][];

            image[0] = new int[] { 0, 0, 0 };
            image[1] = new int[] { 0, 1, 1 };
            //image[2] = new int[] { 1, 0, 1 };

            FloodFill floodFill = new FloodFill();
            image = floodFill.FloodFillIt(image, 1, 1, 1);
        }
    }
}
