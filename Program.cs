using System;
using System.Collections.Generic;
using static MiddleLinkedList;

namespace DataStructures
{
    class Program
    {
        public static void Main(string[] args)
        {
            LongestCommonPrefix commonPrefix = new LongestCommonPrefix();
            commonPrefix.FindLongestCommonPrefix(new string[] { "flower", "flow", "flight" });
        }
    }
}
