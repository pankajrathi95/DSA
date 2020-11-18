/*
https://leetcode.com/problems/friend-circles/
There are N students in a class. Some of them are friends, while some are not. Their friendship is transitive in nature. For example, if A is a direct friend of B, and B is a direct friend of C, then A is an indirect friend of C. And we defined a friend circle is a group of students who are direct or indirect friends.

Given a N*N matrix M representing the friend relationship between students in the class. If M[i][j] = 1, then the ith and jth students are direct friends with each other, otherwise not. And you have to output the total number of friend circles among all the students.

Example 1:

Input: 
[[1,1,0],
 [1,1,0],
 [0,0,1]]
Output: 2
Explanation:The 0th and 1st students are direct friends, so they are in a friend circle. 
The 2nd student himself is in a friend circle. So return 2.
 

Example 2:

Input: 
[[1,1,0],
 [1,1,1],
 [0,1,1]]
Output: 1
Explanation:The 0th and 1st students are direct friends, the 1st and 2nd students are direct friends, 
so the 0th and 2nd students are indirect friends. All of them are in the same friend circle, so return 1.

 

Constraints:

1 <= N <= 200
M[i][i] == 1
M[i][j] == M[j][i]
*/

using System;
using System.Collections.Generic;

public class FriendCircles
{
    public class Graph
    {
        int V;
        public Dictionary<int, List<int>> adjList;
        public Graph(int v)
        {
            V = v;
            adjList = new Dictionary<int, List<int>>();
            for (int i = 0; i < V; i++)
            {
                adjList.Add(i, new List<int>());
            }
        }

        public void AddEdge(int from, int to)
        {
            adjList[from].Add(to);
        }
    }

    public int FindCircleNum(int[][] M)
    {
        //question is similar to find connected components in a graph
        int people = Math.Max(M.Length, M[0].Length);
        Graph graph = new Graph(people);

        for (int i = 0; i < M.Length; i++)
        {
            for (int j = 0; j < M[i].Length; j++)
            {
                if (M[i][j] == 1)
                {
                    graph.AddEdge(i, j);
                }
            }
        }

        int friends = 0;
        bool[] visited = new bool[people];
        //Do a Depth first search on every node and find the connected graphs
        for (int i = 0; i < people; i++)
        {
            if (!visited[i])
            {
                friends++;
                Dfs(visited, i, graph.adjList);
            }
        }

        return friends;
    }

    private void Dfs(bool[] visited, int node, Dictionary<int, List<int>> adjList)
    {
        visited[node] = true;
        foreach (var item in adjList[node])
        {
            if (!visited[item])
            {
                Dfs(visited, item, adjList);
            }
        }
    }
}