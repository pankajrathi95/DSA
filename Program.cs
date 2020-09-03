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

            SortStack SortStack = new SortStack();

            SortStack.Push(1);
            SortStack.Push(2);
            SortStack.Push(3);
            SortStack.Push(4);
            SortStack.Push(5);
            SortStack.Push(6);

            Console.WriteLine(SortStack.Pop());

            Console.WriteLine(SortStack.Pop());
            Console.WriteLine(SortStack.Pop());
            Console.WriteLine(SortStack.Pop());
            Console.WriteLine(SortStack.Pop());
            Console.WriteLine(SortStack.Pop());
            Console.WriteLine(SortStack.Pop());
        }
    }
}
