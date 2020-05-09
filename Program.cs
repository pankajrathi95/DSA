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

            Trie trie = new Trie();
            trie.Insert("car");
            trie.Insert("card");
            trie.Insert("care");
            trie.Insert("careful");
            bool value = trie.ContainsRecursive("cars");
            int count = trie.CountWords();
            string tmep = Trie.LongestCommonPrefix(new string[] { "car", "card", "cardkdd" });
        }
    }
}
