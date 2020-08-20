using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

public class Graph
{
    internal class Node
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

    internal Dictionary<string, Node> nodes = new Dictionary<string, Node>();

    internal Dictionary<Node, List<Node>> adjacencyList = new Dictionary<Node, List<Node>>();

    internal HashSet<Node> traversalValues = new HashSet<Node>();
    public void AddNode(string label)
    {
        var node = new Node(label);
        if (!nodes.ContainsKey(label))
        {
            nodes.Add(label, node);
        }

        if (!adjacencyList.ContainsKey(node))
        {
            adjacencyList.Add(node, new List<Node>());
        }
    }

    public void AddEdge(string from, string to)
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

        adjacencyList.GetValueOrDefault(fromNode).Add(toNode);
    }

    public void Print()
    {
        foreach (var source in adjacencyList.Keys)
        {
            var targets = adjacencyList[source];
            if (targets.Count != 0)
            {
                Console.WriteLine(source.ToString() + " is connected to " + NodePrint(targets));
            }
        }
    }

    private string NodePrint(List<Node> values)
    {
        string value = "[ ";
        foreach (var node in values)
        {
            value += node.ToString() + ", ";
        }

        value += " ]";
        return value;
    }

    public void RemoveNode(string label)
    {
        Node node = null;
        bool flag = nodes.TryGetValue(label, out node);

        if (!flag)
        {
            return;
        }

        foreach (var n in adjacencyList.Keys)
        {
            adjacencyList[n].Remove(node);
        }

        adjacencyList.Remove(node);
        nodes.Remove(label);
    }

    public void RemoveEdge(string from, string to)
    {
        var fromNode = nodes.GetValueOrDefault(from);
        if (fromNode == null)
        {
            return;
        }

        var toNode = nodes.GetValueOrDefault(to);
        if (toNode == null)
        {
            return;
        }

        adjacencyList[fromNode].Remove(toNode);
    }

    public void DepthFirstTraversal(string label)
    {
        var node = nodes.GetValueOrDefault(label);
        if (node == null)
        {
            throw new InvalidProgramException();
        }

        DepthFirstTraversal(node);
    }

    private void DepthFirstTraversal(Node node)
    {
        traversalValues.Add(node);
        Console.Write(node.ToString() + ", ");

        List<Node> items = adjacencyList[node];
        items.Sort(new Sorting());

        foreach (var item in items)
        {
            if (!traversalValues.Contains(item))
            {
                DepthFirstTraversal(item);
            }
        }
    }

    public void DepthFirstTraversalIterative(string label)
    {
        var node = nodes.GetValueOrDefault(label);
        if (node == null)
        {
            throw new InvalidProgramException();
        }

        Stack<Node> stack = new Stack<Node>();
        stack.Push(node);
        while (stack.Count != 0)
        {
            var current = stack.Pop();

            if (traversalValues.Contains(current))
            {
                continue;
            }

            Console.Write(current.ToString() + ", ");
            traversalValues.Add(current);
            List<Node> items = adjacencyList[current];
            foreach (var item in items)
            {
                if (!traversalValues.Contains(item))
                {
                    stack.Push(item);
                }
            }
        }
    }

    public void BreathFirstTraversal(string label)
    {
        var node = nodes.GetValueOrDefault(label);
        if (node == null)
        {
            throw new InvalidProgramException();
        }

        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(node);
        while (queue.Count != 0)
        {
            var current = queue.Dequeue();

            if (traversalValues.Contains(current))
            {
                continue;
            }

            Console.Write(current.ToString() + ", ");
            traversalValues.Add(current);
            List<Node> items = adjacencyList[current];
            foreach (var item in items)
            {
                if (!traversalValues.Contains(item))
                {
                    queue.Enqueue(item);
                }
            }
        }
    }

    public List<string> TopologicalSort()
    {
        Stack<Node> stack = new Stack<Node>();
        HashSet<Node> visited = new HashSet<Node>();
        foreach (var node in nodes.Values)
        {
            TopologicalSort(node, visited, stack);
        }

        List<string> sorted = new List<string>();

        while (stack.Count != 0)
        {
            sorted.Add(stack.Pop().ToString());
        }

        return sorted;
    }

    private void TopologicalSort(Node node, HashSet<Node> visited, Stack<Node> stack)
    {
        if (visited.Contains(node))
        {
            return;
        }

        visited.Add(node);

        foreach (var item in adjacencyList[node])
        {
            TopologicalSort(item, visited, stack);
        }

        stack.Push(node);
    }

    public bool HasCycle()
    {
        HashSet<Node> all = new HashSet<Node>();
        HashSet<Node> visiting = new HashSet<Node>();
        HashSet<Node> visited = new HashSet<Node>();

        foreach (var node in nodes.Values)
        {
            all.Add(node);
        }

        while (all.Count != 0)
        {
            var hashSetEnumerator = all.GetEnumerator();
            Node current = null;
            while (hashSetEnumerator.MoveNext())
            {
                current = hashSetEnumerator.Current;
                break;
            }

            if (HasCycle(current, all, visiting, visited))
            {
                return true;
            }
        }

        return false;
    }

    private bool HasCycle(Node current, HashSet<Node> all, HashSet<Node> visiting, HashSet<Node> visited)
    {
        all.Remove(current);
        visiting.Add(current);

        foreach (var item in adjacencyList[current])
        {
            if (visited.Contains(item))
            {
                continue;
            }

            if (visiting.Contains(item))
            {
                return true;
            }

            if (HasCycle(item, all, visiting, visited))
            {
                return true;
            }
        }

        visiting.Remove(current);
        visited.Add(current);
        return false;
    }

    internal class Sorting : IComparer<Node>
    {
        public int Compare([AllowNull] Node x, [AllowNull] Node y)
        {
            return x.ToString().CompareTo(y.ToString());
        }
    }
}