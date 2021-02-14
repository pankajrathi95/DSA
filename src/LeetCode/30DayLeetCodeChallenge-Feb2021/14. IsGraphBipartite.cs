/*
#785 - https://leetcode.com/problems/is-graph-bipartite/
Given an undirected graph, return true if and only if it is bipartite.

Recall that a graph is bipartite if we can split its set of nodes into two independent subsets A and B, such that every edge in the graph has one node in A and another node in B.

The graph is given in the following form: graph[i] is a list of indexes j for which the edge between nodes i and j exists. Each node is an integer between 0 and graph.length - 1. There are no self edges or parallel edges: graph[i] does not contain i, and it doesn't contain any element twice.

 

Example 1:


Input: graph = [[1,3],[0,2],[1,3],[0,2]]
Output: true
Explanation: We can divide the vertices into two groups: {0, 2} and {1, 3}.

Example 2:


Input: graph = [[1,2,3],[0,2],[0,1,3],[0,2]]
Output: false
Explanation: We cannot find a way to divide the set of nodes into two independent subsets.
 

Constraints:

1 <= graph.length <= 100
0 <= graph[i].length < 100
0 <= graph[i][j] <= graph.length - 1
graph[i][j] != i
All the values of graph[i] are unique.
The graph is guaranteed to be undirected. 
*/

using System.Collections.Generic;

public class IsGraphBipartite
{
    Dictionary<int, IList<int>> adjList = new Dictionary<int, IList<int>>();
    Dictionary<int, int> colors = new Dictionary<int, int>();
    public bool IsBipartite(int[][] graph)
    {
        FillGraph(graph);
        for (int i = 0; i < graph.Length; i++)
        {
            if (colors[i] == -1 && !Bfs(i))
            {
                return false;
            }
        }

        return true;
    }

    private void FillGraph(int[][] graph)
    {
        for (int i = 0; i < graph.Length; i++)
        {
            colors.Add(i, -1);
            adjList.Add(i, new List<int>());
            for (int j = 0; j < graph[i].Length; j++)
            {
                adjList[i].Add(graph[i][j]);
            }
        }
    }

    private bool Bfs(int node)
    {
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(node);
        colors[node] = 0;
        while (queue.Count != 0)
        {
            int current = queue.Dequeue();
            int currentColor = colors[current];
            foreach (var nei in adjList[current])
            {
                if (currentColor == colors[nei])
                {
                    return false;
                }

                if (colors[nei] == -1)
                {
                    colors[nei] = 1 - currentColor;
                    queue.Enqueue(nei);
                }
            }
        }

        return true;
    }
}