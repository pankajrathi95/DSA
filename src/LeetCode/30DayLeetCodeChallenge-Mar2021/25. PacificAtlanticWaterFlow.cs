/*
#417 - https://leetcode.com/problems/pacific-atlantic-water-flow/

Given an m x n matrix of non-negative integers representing the height of each unit cell in a continent, the "Pacific ocean" touches the left and top edges of the matrix and the "Atlantic ocean" touches the right and bottom edges.

Water can only flow in four directions (up, down, left, or right) from a cell to another one with height equal or lower.

Find the list of grid coordinates where water can flow to both the Pacific and Atlantic ocean.

Note:

The order of returned grid coordinates does not matter.
Both m and n are less than 150.
 

Example:

Given the following 5x5 matrix:

  Pacific ~   ~   ~   ~   ~ 
       ~  1   2   2   3  (5) *
       ~  3   2   3  (4) (4) *
       ~  2   4  (5)  3   1  *
       ~ (6) (7)  1   4   5  *
       ~ (5)  1   1   2   4  *
          *   *   *   *   * Atlantic

Return:

[[0, 4], [1, 3], [1, 4], [2, 2], [3, 0], [3, 1], [4, 0]] (positions with parentheses in above matrix).
*/

using System.Collections.Generic;

public class PacificAtlanticWaterFlow
{
    public IList<IList<int>> PacificAtlantic(int[][] matrix)
    {
        if (matrix == null || matrix.Length == 0)
        {
            return new List<IList<int>>();
        }

        int m = matrix.Length, n = matrix[0].Length;
        bool[][] pacific = new bool[m][];
        bool[][] atlantic = new bool[m][];
        for (int i = 0; i < m; i++)
        {
            pacific[i] = new bool[n];
            atlantic[i] = new bool[n];
        }

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if ((i == 0 || j == 0) && (!pacific[i][j]))
                {
                    Dfs(i, j, m, n, matrix, pacific);
                }

                if ((i == m - 1 || j == n - 1) && (!atlantic[i][j]))
                {
                    Dfs(i, j, m, n, matrix, atlantic);
                }
            }
        }

        IList<IList<int>> result = new List<IList<int>>();
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (pacific[i][j] && atlantic[i][j])
                {
                    result.Add(new List<int>() { i, j });
                }
            }
        }

        return result;
    }

    private void Dfs(int i, int j, int m, int n, int[][] matrix, bool[][] visited)
    {
        if (i < 0 || j < 0 || i >= m || j >= n || visited[i][j])
        {
            return;
        }

        visited[i][j] = true;
        if (i - 1 >= 0 && matrix[i][j] <= matrix[i - 1][j])
        {
            Dfs(i - 1, j, m, n, matrix, visited);
        }

        if (j - 1 >= 0 && matrix[i][j] <= matrix[i][j - 1])
        {
            Dfs(i, j - 1, m, n, matrix, visited);
        }

        if (i + 1 < m && matrix[i][j] <= matrix[i + 1][j])
        {
            Dfs(i + 1, j, m, n, matrix, visited);
        }

        if (j + 1 < n && matrix[i][j] <= matrix[i][j + 1])
        {
            Dfs(i, j + 1, m, n, matrix, visited);
        }
    }
}