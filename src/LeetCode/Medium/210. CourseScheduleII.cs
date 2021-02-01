/*
https://leetcode.com/problems/course-schedule-ii/

There are a total of n courses you have to take labelled from 0 to n - 1.

Some courses may have prerequisites, for example, if prerequisites[i] = [ai, bi] this means you must take the course bi before the course ai.

Given the total number of courses numCourses and a list of the prerequisite pairs, return the ordering of courses you should take to finish all courses.

If there are many valid answers, return any of them. If it is impossible to finish all courses, return an empty array.

 

Example 1:

Input: numCourses = 2, prerequisites = [[1,0]]
Output: [0,1]
Explanation: There are a total of 2 courses to take. To take course 1 you should have finished course 0. So the correct course order is [0,1].
Example 2:

Input: numCourses = 4, prerequisites = [[1,0],[2,0],[3,1],[3,2]]
Output: [0,2,1,3]
Explanation: There are a total of 4 courses to take. To take course 3 you should have finished both courses 1 and 2. Both courses 1 and 2 should be taken after you finished course 0.
So one correct course order is [0,1,2,3]. Another correct ordering is [0,2,1,3].
Example 3:

Input: numCourses = 1, prerequisites = []
Output: [0]
 

Constraints:

1 <= numCourses <= 2000
0 <= prerequisites.length <= numCourses * (numCourses - 1)
prerequisites[i].length == 2
0 <= ai, bi < numCourses
ai != bi
All the pairs [ai, bi] are distinct.
*/

using System.Collections.Generic;

public class CourseScheduleII
{
    public List<int>[] adjList;
    public int[] FindOrder(int numCourses, int[][] prerequisites)
    {
        int[] result = new int[numCourses];
        adjList = new List<int>[numCourses];
        if (prerequisites.Length == 0)
        {
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = i;
            }

            return result;
        }

        BuildGraph(prerequisites);
        if (CycleExists())
        {
            return new int[] { };
        }

        TopologicalSort(result);
        return result;
    }

    private void TopologicalSort(int[] result)
    {
        Stack<int> stack = new Stack<int>();
        bool[] visited = new bool[adjList.Length];
        for (int i = 0; i < adjList.Length; i++)
        {
            if (!visited[i])
            {
                TopologicalSort(stack, i, visited);
            }
        }

        int index = 0;
        while (stack.Count != 0)
        {
            result[index++] = stack.Pop();
        }
    }

    private void TopologicalSort(Stack<int> stack, int current, bool[] visited)
    {
        visited[current] = true;
        foreach (var item in adjList[current])
        {
            if (!visited[item])
            {
                TopologicalSort(stack, item, visited);
            }
        }

        stack.Push(current);
    }

    public bool CycleExists()
    {
        bool[] visited = new bool[adjList.Length];
        bool[] recStack = new bool[adjList.Length];
        for (int i = 0; i < adjList.Length; i++)
        {
            if (CycleExists(visited, i, recStack))
            {
                return true;
            }
        }

        return false;
    }

    public bool CycleExists(bool[] visited, int current, bool[] recStack)
    {
        if (recStack[current])
            return true;

        if (visited[current])
            return false;

        visited[current] = true;
        recStack[current] = true;

        foreach (var item in adjList[current])
        {
            if (CycleExists(visited, item, recStack))
            {
                return true;
            }
        }

        recStack[current] = false;
        return false;
    }

    public void BuildGraph(int[][] prerequisites)
    {
        for (int i = 0; i < adjList.Length; i++)
        {
            adjList[i] = new List<int>();
        }

        foreach (var prerequisite in prerequisites)
        {
            AddEdge(prerequisite[1], prerequisite[0]);
        }
    }

    public void AddEdge(int u, int v)
    {
        adjList[u].Add(v);
    }
}