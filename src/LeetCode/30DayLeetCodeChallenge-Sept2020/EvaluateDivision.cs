/*
You are given equations in the format A / B = k, where A and B are variables represented as strings, and k is a real number (floating-point number). Given some queries, return the answers. If the answer does not exist, return -1.0.

The input is always valid. You may assume that evaluating the queries will result in no division by zero and there is no contradiction.

 

Example 1:

Input: equations = [["a","b"],["b","c"]], values = [2.0,3.0], queries = [["a","c"],["b","a"],["a","e"],["a","a"],["x","x"]]
Output: [6.00000,0.50000,-1.00000,1.00000,-1.00000]
Explanation: 
Given: a / b = 2.0, b / c = 3.0
queries are: a / c = ?, b / a = ?, a / e = ?, a / a = ?, x / x = ?
return: [6.0, 0.5, -1.0, 1.0, -1.0 ]
Example 2:

Input: equations = [["a","b"],["b","c"],["bc","cd"]], values = [1.5,2.5,5.0], queries = [["a","c"],["c","b"],["bc","cd"],["cd","bc"]]
Output: [3.75000,0.40000,5.00000,0.20000]
Example 3:

Input: equations = [["a","b"]], values = [0.5], queries = [["a","b"],["b","a"],["a","c"],["x","y"]]
Output: [0.50000,2.00000,-1.00000,-1.00000]
 

Constraints:

1 <= equations.length <= 20
equations[i].length == 2
1 <= equations[i][0], equations[i][1] <= 5
values.length == equations.length
0.0 < values[i] <= 20.0
1 <= queries.length <= 20
queries[i].length == 2
1 <= queries[i][0], queries[i][1] <= 5
equations[i][0], equations[i][1], queries[i][0], queries[i][1] consist of lower case English letters and digits.

   Hide Hint #1  
Do you recognize this as a graph problem?
*/


using System.Collections.Generic;

public class EvaluateDivision
{
    public class Node
    {
        public string label;
        public bool visited;
        public List<Edge> edges = new List<Edge>();

        public void AddEdge(Node to, double weight)
        {
            edges.Add(new Edge(this, to, weight));
        }

        public List<Edge> GetEdges()
        {
            return edges;
        }

        public Node(string label)
        {
            this.label = label;
            visited = false;
        }

    }

    public class Edge
    {
        public Node from;
        public Node to;
        public double weight;
        public Edge(Node from, Node to, double weight)
        {
            this.from = from;
            this.to = to;
            this.weight = weight;
        }

    }

    public Dictionary<string, Node> nodes = new Dictionary<string, Node>();

    public void AddNode(string label)
    {
        var node = new Node(label);
        if (!nodes.ContainsKey(label))
        {
            nodes.Add(label, node);
        }

    }

    public void AddEdge(string from, string to, double weight)
    {
        Node fromNode = nodes[from];
        Node toNode = nodes[to];

        fromNode.AddEdge(toNode, weight);
    }

    public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries)
    {
        double[] result = new double[queries.Count];
        for (int i = 0; i < equations.Count; i++)
        {
            AddNode(equations[i][0]);
            AddNode(equations[i][1]);

            AddEdge(equations[i][0], equations[i][1], values[i]);
            AddEdge(equations[i][1], equations[i][0], 1.0 / values[i]);
        }

        int j = 0;
        foreach (var query in queries)
        {
            if (!nodes.ContainsKey(query[0]))
            {
                result[j++] = -1.0;
                continue;
            }

            if (!nodes.ContainsKey(query[1]))
            {
                result[j++] = -1.0;
                continue;
            }

            Node from = nodes[query[0]];
            Node to = nodes[query[1]];
            result[j++] = Dfs(from, to, 1.0);
            ResetStates();
        }

        return result;
    }

    public void ResetStates()
    {
        foreach (var node in nodes)
        {
            node.Value.visited = false;
        }
    }

    public double Dfs(Node start, Node end, double product)
    {
        if (start == null || end == null)
        {
            return -1.0;
        }

        if (start.label.Equals(end.label))
        {
            return product;
        }

        start.visited = true;
        foreach (var neighbour in start.edges)
        {
            if (!neighbour.to.visited)
            {
                double cand = Dfs(neighbour.to, end, product * neighbour.weight);
                if (cand != -1)
                {
                    return cand;
                }
            }
        }

        return -1;
    }
}
