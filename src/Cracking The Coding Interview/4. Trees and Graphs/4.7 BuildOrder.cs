using System;
using System.Collections.Generic;

public class BuildOrder
{
    public class Node
    {
        private string label;

        public Node(string label)
        {
            this.label = label;
        }

        public override string ToString()
        {
            return label;
        }
    }

    private Dictionary<string, Node> nodes = new Dictionary<string, Node>();

    private Dictionary<Node, List<Node>> adjacencyList = new Dictionary<Node, List<Node>>();

    public void AddNode(string label)
    {
        Node node = new Node(label);
        if (!nodes.ContainsKey(label))
        {
            nodes.Add(label, node);
        }

        if (!adjacencyList.ContainsKey(node))
        {
            adjacencyList.Add(node, new List<Node>());
        }
    }

    public void AddEdge(string start, string end)
    {
        var fromNode = nodes.GetValueOrDefault(start);
        if (fromNode == null)
        {
            throw new InvalidProgramException();
        }

        var toNode = nodes.GetValueOrDefault(end);
        if (toNode == null)
        {
            throw new InvalidProgramException();
        }

        adjacencyList[fromNode].Add(toNode);
    }

    public List<string> BuildTheOrder()
    {
        Stack<Node> stack = new Stack<Node>();
        HashSet<Node> visited = new HashSet<Node>();

        foreach (var node in nodes.Values)
        {
            TopologicalSort(node, visited, stack);
        }

        List<string> result = new List<string>();
        while (stack.Count != 0)
        {
            result.Add(stack.Pop().ToString());
        }

        return result;
    }

    private void TopologicalSort(Node node, HashSet<Node> visited, Stack<Node> stack)
    {
        if (visited.Contains(node))
        {
            return;
        }

        visited.Add(node);
        foreach (var neighbour in adjacencyList[node])
        {
            TopologicalSort(neighbour, visited, stack);
        }

        stack.Push(node);
    }
}