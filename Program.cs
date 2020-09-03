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

            StackofPlates stackofPlates = new StackofPlates(3);
            stackofPlates.Push(1);
            stackofPlates.Push(2);
            stackofPlates.Push(3);
            stackofPlates.Push(4);
            stackofPlates.PopAt(1);
            stackofPlates.PopAt(1);
            stackofPlates.PopAt(5);
            Console.WriteLine(stackofPlates.Pop());
            Console.WriteLine(stackofPlates.Pop());
            Console.WriteLine(stackofPlates.Pop());
            Console.WriteLine(stackofPlates.Pop());
        }
    }
}
