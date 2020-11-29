/*
https://leetcode.com/problems/shortest-path-in-binary-matrix/

In an N by N square grid, each cell is either empty (0) or blocked (1).

A clear path from top-left to bottom-right has length k if and only if it is composed of cells C_1, C_2, ..., C_k such that:

Adjacent cells C_i and C_{i+1} are connected 8-directionally (ie., they are different and share an edge or corner)
C_1 is at location (0, 0) (ie. has value grid[0][0])
C_k is at location (N-1, N-1) (ie. has value grid[N-1][N-1])
If C_i is located at (r, c), then grid[r][c] is empty (ie. grid[r][c] == 0).
Return the length of the shortest such clear path from top-left to bottom-right.  If such a path does not exist, return -1.

 

Example 1:

Input: [[0,1],[1,0]]


Output: 2

Example 2:

Input: [[0,0,0],[1,1,0],[1,1,0]]


Output: 4

 

Note:

1 <= grid.length == grid[0].length <= 100
grid[r][c] is 0 or 1
*/

using System.Collections.Generic;

public class ShortestPathInBinaryMatrix
{
    public int ShortestPathBinaryMatrix(int[][] grid)
    {
        if (grid[0][0] == 1)
        {
            return -1;
        }

        int m = grid.Length, n = grid[0].Length;

        int ans = 0;
        int[][] dir = new int[8][];
        dir[0] = new int[] { 1, 0 };
        dir[1] = new int[] { -1, 0 };
        dir[2] = new int[] { 0, 1 };
        dir[3] = new int[] { 0, -1 };
        dir[4] = new int[] { 1, 1 };
        dir[5] = new int[] { -1, -1 };
        dir[6] = new int[] { 1, -1 };
        dir[7] = new int[] { -1, 1 };

        bool[][] visited = new bool[grid.Length][];
        for (int i = 0; i < visited.Length; i++)
        {
            visited[i] = new bool[grid[0].Length];
        }

        Queue<int[]> queue = new Queue<int[]>();
        queue.Enqueue(new int[] { 0, 0 });
        while (queue.Count != 0)
        {
            int size = queue.Count;
            for (int i = 0; i < size; i++)
            {
                int[] item = queue.Dequeue();
                if (item[0] == m - 1 && item[1] == n - 1)
                {
                    return ans + 1;
                }

                for (int j = 0; j < dir.Length; j++)
                {
                    int x = dir[j][0] + item[0];
                    int y = dir[j][1] + item[1];

                    if (x >= 0 && y >= 0 && x < m && y < n && !visited[x][y] && grid[x][y] == 0)
                    {
                        visited[x][y] = true;
                        queue.Enqueue(new int[] { x, y });
                    }
                }
            }

            ans++;
        }

        return -1;
    }
}