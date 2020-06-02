using System;
using System.Collections.Generic;
using static MiddleLinkedList;

namespace DataStructures
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //nsertANodeAtTheTail insert = new InsertANodeAtTheTail();
            var head = InsertANodeAtTheTail.InsertNodeAtTail(null, 141);
            var second = InsertANodeAtTheTail.InsertNodeAtTail(head, 200);
        }
    }
}
