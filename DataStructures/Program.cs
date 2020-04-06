using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            GroupAnagrams groupAnagrams = new GroupAnagrams();
            groupAnagrams.GroupTheAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });
        }
    }
}
