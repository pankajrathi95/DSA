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

            Console.WriteLine(IsUnique.IsUniqueOrNot("pankaj"));

            Console.WriteLine(IsUnique.IsUniqueOrNot("a"));

            //Console.WriteLine(IsUnique.IsUniqueOrNot(""));
            Console.WriteLine(IsUnique.IsUniqueOrNot("qwertyuopm"));
            Console.WriteLine(IsUnique.IsUniqueOrNot("213124"));

        }
    }
}
