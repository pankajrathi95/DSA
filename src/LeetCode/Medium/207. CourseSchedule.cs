/*
There are a total of numCourses courses you have to take, labeled from 0 to numCourses-1.

Some courses may have prerequisites, for example to take course 0 you have to first take course 1, which is expressed as a pair: [0,1]

Given the total number of courses and a list of prerequisite pairs, is it possible for you to finish all courses?

 

Example 1:

Input: numCourses = 2, prerequisites = [[1,0]]
Output: true
Explanation: There are a total of 2 courses to take. 
             To take course 1 you should have finished course 0. So it is possible.
Example 2:

Input: numCourses = 2, prerequisites = [[1,0],[0,1]]
Output: false
Explanation: There are a total of 2 courses to take. 
             To take course 1 you should have finished course 0, and to take course 0 you should
             also have finished course 1. So it is impossible.
 

Constraints:

The input prerequisites is a graph represented by a list of edges, not adjacency matrices. Read more about how a graph is represented.
You may assume that there are no duplicate edges in the input prerequisites.
1 <= numCourses <= 10^5
*/

using System.Collections.Generic;

public class CourseSchedule
{
    public bool CanFinish(int numCourses, int[][] prerequisites)
    {
        List<int>[] adjList = new List<int>[numCourses];
        for (int i = 0; i < adjList.Length; i++)
        {
            adjList[i] = new List<int>();
        }

        foreach (var pre in prerequisites)
        {
            adjList[pre[0]].Add(pre[1]);
        }

        //0 - unvisited, 1 - visiting, 2 - visited.
        int[] visited = new int[numCourses];
        for (int i = 0; i < adjList.Length; i++)
        {
            if (visited[i] == 0 && !Dfs(adjList, visited, i))
            {
                return false;
            }
        }

        return true;
    }



    public bool Dfs(List<int>[] adjList, int[] visited, int v)
    {
        if (visited[v] == 1)
        {
            return false;
        }

        visited[v] = 1;
        foreach (int ad in adjList[v])
        {
            if (!Dfs(adjList, visited, ad))
            {
                return false;
            }
        }
        visited[v] = 2;
        return true;
    }
}