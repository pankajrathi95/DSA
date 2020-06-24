using System;
using System.Collections.Generic;

public class WeightedGraph
{
    internal class Node
    {
        private string label;

        private List<Edge> edges = new List<Edge>();

        public Node(string label)
        {
            this.label = label;
        }

        public override string ToString()
        {
            return label;
        }

        public void AddEdge(Node to, int weight)
        {
            edges.Add(new Edge(this, to, weight));
        }

        public List<Edge> GetEdges()
        {
            return edges;
        }
    }

    internal class Edge
    {
        internal Node from;
        internal Node to;
        internal int weight;

        public Edge(Node from, Node to, int weight)
        {
            this.from = from;
            this.to = to;
            this.weight = weight;
        }

        public override string ToString()
        {
            return from + " -> " + to;
        }
    }

    internal Dictionary<string, Node> nodes = new Dictionary<string, Node>();

    //internal Dictionary<Node, List<Edge>> edges = new Dictionary<Node, List<Edge>>();

    public void AddNode(string label)
    {
        var node = new Node(label);

        if (!nodes.ContainsKey(label))
        {
            nodes.Add(label, node);
        }

        /*if (!edges.ContainsKey(node))
        {
            edges.Add(node, new List<Edge>());
        }*/
    }

    public void AddEdge(string from, string to, int weight)
    {
        var fromNode = nodes.GetValueOrDefault(from);
        if (fromNode == null)
        {
            throw new InvalidProgramException();
        }

        var toNode = nodes.GetValueOrDefault(to);
        if (toNode == null)
        {
            throw new InvalidProgramException();
        }

        fromNode.AddEdge(toNode, weight);
        toNode.AddEdge(fromNode, weight);
        //edges.GetValueOrDefault(fromNode).Add(new Edge(fromNode, toNode, weight));
        //edges.GetValueOrDefault(toNode).Add(new Edge(toNode, fromNode, weight));
    }

    public void Print()
    {
        foreach (var source in nodes.Values)
        {
            var targets = source.GetEdges();
            if (targets.Count != 0)
            {
                Console.WriteLine(source.ToString() + " is connected to " + NodePrint(targets));
            }
        }
    }

    public bool HasCycle()
    {
        HashSet<Node> visited = new HashSet<Node>();

        foreach (var node in nodes.Values)
        {
            if (!visited.Contains(node) && HasCycle(node, null, visited))
            {
                return true;
            }
        }

        return false;
    }

    private bool HasCycle(Node node, Node parent, HashSet<Node> visited)
    {
        visited.Add(node);

        foreach (var edge in node.GetEdges())
        {
            if (edge.to == parent)
            {
                continue;
            }

            if (visited.Contains(edge.to) || HasCycle(edge.to, node, visited))
            {
                return true;
            }
        }

        return false;
    }

    private string NodePrint(List<Edge> values)
    {
        string value = "[ ";
        foreach (var node in values)
        {
            value += node.ToString() + ", ";
        }

        value += " ]";
        return value;
    }
}