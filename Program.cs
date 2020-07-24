using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ValidPalindrome validPalindrome = new ValidPalindrome();
            validPalindrome.IsPalindrome("A man, a plan, a canal: Panama");
        }
    }
}
