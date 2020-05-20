using System;
using System.Collections.Generic;
using static MiddleLinkedList;

namespace DataStructures
{
    class Program
    {
        public static void Main(string[] args)
        {
            ValidParentheses parentheses = new ValidParentheses();
            parentheses.IsValids("()");
        }
    }
}
