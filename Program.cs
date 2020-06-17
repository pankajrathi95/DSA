using System;

namespace DataStructures
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Graph graph = new Graph();

            graph.AddNode("A");
            graph.AddNode("B");
            graph.AddNode("C");
            graph.AddNode("D");
            graph.AddNode("E");

            graph.AddEdge("A", "B");
            graph.AddEdge("A", "E");

            graph.AddEdge("B", "E");

            graph.AddEdge("C", "A");
            graph.AddEdge("C", "B");
            graph.AddEdge("C", "D");

            graph.AddEdge("D", "E");

            graph.DepthFirstTraversal("C");
        }
    }
}
