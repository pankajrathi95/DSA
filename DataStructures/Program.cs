using System;
using System.Collections.Generic;
using static MiddleLinkedList;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ArrayManipulation arrayManipulation = new ArrayManipulation();
            arrayManipulation.CalcArrayManipulation(5, new int[3, 3] { { 1, 2, 100 }, { 2, 5, 100 }, { 3, 4, 100 } });
        }
    }
}
