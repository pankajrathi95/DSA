using System;
using System.Collections.Generic;

namespace DataStructures
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<List<string>> vals = new List<List<string>>();
            List<string> one = new List<string>();
            one.Add("MUC");
            one.Add("LHR");
            vals.Add(one);

            List<string> two = new List<string>();
            two.Add("JFK");
            two.Add("MUC");
            vals.Add(two);
            List<string> three = new List<string>();
            three.Add("SFO");
            three.Add("SJC");
            vals.Add(three);
            List<string> four = new List<string>();
            four.Add("LHR");
            four.Add("SFO");
            vals.Add(four);

            ReconstructItinerary reconstructItinerary = new ReconstructItinerary();
            reconstructItinerary.FindItinerary(vals);

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
