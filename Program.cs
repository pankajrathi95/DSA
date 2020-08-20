using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!");

            Console.WriteLine(CheckPermutation.CheckIfPermutation("pankaj", "pankaf"));

            Console.WriteLine(CheckPermutation.CheckIfPermutation("a", "ab"));

            //Console.WriteLine(IsUnique.IsUniqueOrNot(""));
            Console.WriteLine(CheckPermutation.CheckIfPermutation("qwertyuopm", "qweroyutpm"));
            Console.WriteLine(CheckPermutation.CheckIfPermutation("213124", "dasdasd"));

        }
    }
}
