using System;
using static MiddleLinkedList;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BackspaceStringCompare backspaceString = new BackspaceStringCompare();
            backspaceString.BackspaceCompare("y#fo##f", "y#f#o##f");
        }
    }
}
