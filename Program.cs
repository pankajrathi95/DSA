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

            RouteBetweenNodes routeBetweenNodes = new RouteBetweenNodes();
            routeBetweenNodes.AddNode("A");
            routeBetweenNodes.AddNode("B");
            routeBetweenNodes.AddNode("C");
            routeBetweenNodes.AddNode("D");

            routeBetweenNodes.AddEdge("A", "B");
            routeBetweenNodes.AddEdge("A", "D");
            routeBetweenNodes.AddEdge("C", "A");

            Console.WriteLine(routeBetweenNodes.Search("A", "D"));
            Console.WriteLine(routeBetweenNodes.Search("B", "A"));
            Console.WriteLine(routeBetweenNodes.Search("C", "A"));
        }
    }
}
