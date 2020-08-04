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
            List<int> a = new List<int>();
            a.Add(4);
            a.Add(6);
            a.Add(5);
            a.Add(3);
            a.Add(3);
            a.Add(1);

            PickingNumbers.PickingTheNumbers(a);
        }
    }
}
