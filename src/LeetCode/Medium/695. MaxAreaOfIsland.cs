/*

*/

using System;

public class MaxAreaOfIsland
{

    public int MaxAreaOfIslands(int[][] grid)
    {
        int m = grid.Length, n = grid[0].Length;
        bool[][] visited = new bool[m][];
        int maxArea = 0;

        for (int i = 0; i < m; i++)
        {
            visited[i] = new bool[n];
        }

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (!visited[i][j] && grid[i][j] == 1)
                {
                    maxArea = Math.Max(maxArea, Area(i, j, m, n, grid, visited, 1));
                }
            }
        }

        return maxArea;
    }

    private int Area(int i, int j, int m, int n, int[][] grid, bool[][] visited, int count)
    {
        if (i < 0 || j < 0 || i >= m || j >= n || visited[i][j] || grid[i][j] == 0)
        {
            return 0;
        }

        visited[i][j] = true;
        return 1 + Area(i + 1, j, m, n, grid, visited, count + 1) +
        Area(i - 1, j, m, n, grid, visited, count + 1) +
        Area(i, j + 1, m, n, grid, visited, count + 1) +
        Area(i, j - 1, m, n, grid, visited, count + 1);

    }
}