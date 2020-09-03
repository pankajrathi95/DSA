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

            StackMin stackMin = new StackMin(10);
            stackMin.Push(11);
            Console.WriteLine(stackMin.Min());
            stackMin.Push(5);
            Console.WriteLine(stackMin.Min());
            stackMin.Push(9);
            Console.WriteLine(stackMin.Min());
            stackMin.Pop();
            Console.WriteLine(stackMin.Min());
            stackMin.Pop();
            Console.WriteLine(stackMin.Min());
        }
    }
}
