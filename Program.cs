using System;
using System.Collections.Generic;
using static MiddleLinkedList;

namespace DataStructures
{
    class Program
    {
        public static void Main(string[] args)
        {
            FindAllAnagrams findAllAnagrams = new FindAllAnagrams();
            findAllAnagrams.FindAnagrams("cbaebabacd", "abc");
        }
    }
}
