using System;
using System.Collections.Generic;

public class RouteBetweenNodes
{
    public class Node
    {
        private string label;

        public Node(string label)
        {
            this.label = label;
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

    public bool Search(string from, string to)
    {
        var fromNode = nodes[from];
        var toNode = nodes[to];

        HashSet<Node> visited = new HashSet<Node>();
        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(fromNode);
        while (queue.Count != 0)
        {
            var current = queue.Dequeue();
            if (visited.Contains(current))
            {
                continue;
            }

            visited.Add(current);
            if (current == toNode)
            {
                return true;
            }
            foreach (var neighbor in adjacencyList[current])
            {
                if (!visited.Contains(neighbor))
                {
                    queue.Enqueue(neighbor);
                }
            }
        }
        return false;
    }
}