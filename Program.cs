using System;
using System.Collections.Generic;

namespace DataStructures
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            HammingDistance distance = new HammingDistance();
            distance.FindHammingDistance(1, 4);

            // Graph graph = new Graph();

            // graph.AddNode("A");
            // graph.AddNode("B");
            // graph.AddNode("C");
            // graph.AddNode("D");
            // graph.AddNode("E");

            // graph.AddEdge("A", "B");
            // graph.AddEdge("A", "E");

            // graph.AddEdge("B", "E");

            // graph.AddEdge("C", "A");
            // graph.AddEdge("C", "B");
            // graph.AddEdge("C", "D");

            // graph.AddEdge("D", "E");



            // Console.WriteLine(graph.HasCycle());

            // WeightedGraph weightedGraph = new WeightedGraph();
            // weightedGraph.AddNode("A");
            // weightedGraph.AddNode("B");
            // weightedGraph.AddNode("C");

            // weightedGraph.AddEdge("A", "B", 10);
            // weightedGraph.AddEdge("A", "C", 20);

            // weightedGraph.Print();
        }
    }
}
