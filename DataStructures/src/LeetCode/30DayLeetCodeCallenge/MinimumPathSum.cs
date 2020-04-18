/*
Given a m x n grid filled with non-negative numbers, find a path from top left to bottom right which minimizes the sum of all numbers along its path.

Note: You can only move either down or right at any point in time.

Example:

Input:
[
  [1,3,1],
  [1,5,1],
  [4,2,1]
]
Output: 7
Explanation: Because the path 1→3→1→1→1 minimizes the sum.
*/

using System;

public class MinimumPathSum
{
    public int MinPathSum(int[][] grid)
    {
        if (grid == null || grid.Length == 0)
        {
            return 0;
        }

        int[][] sum = new int[grid.Length][];
        for (int i = 0; i < grid.Length; i++)
        {
            sum[i] = new int[grid[i].Length];
            for (int j = 0; j < grid[i].Length; j++)
            {

                sum[i][j] += grid[i][j];
                if (i > 0 && j > 0)
                {
                    sum[i][j] += Math.Min(sum[i][j - 1], sum[i - 1][j]);
                }
                else if (j > 0)
                {
                    sum[i][j] += sum[i][j - 1];
                }
                else if (i > 0)
                {
                    sum[i][j] += sum[i - 1][j];
                }
            }
        }

        return sum[grid.Length - 1][grid[0].Length - 1];
    }
}