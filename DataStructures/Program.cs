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
            ValidParenthesisString valid = new ValidParenthesisString();
            Console.WriteLine(valid.CheckValidString("(())((())()()(*)(*()(())())())()()((()())((()))(*"));
        }
    }
}
