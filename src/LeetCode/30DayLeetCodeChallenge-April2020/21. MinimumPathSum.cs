/*
#64 - https://leetcode.com/problems/minimum-path-sum/
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
    //DP solution
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

    int min = Int32.MaxValue;
    //Recursive Solution (TLE)
    public int MinPathSum_Rec(int[][] grid)
    {
        Sum(grid, 0, 0, 0);
        return min;
    }

    private void Sum(int[][] grid, int i, int j, int sum)
    {
        if (i >= grid.Length || j >= grid[i].Length)
        {
            return;
        }

        if (i == grid.Length - 1 && j == grid[i].Length - 1)
        {
            min = Math.Min(sum + grid[i][j], min);
            return;
        }

        Sum(grid, i + 1, j, sum + grid[i][j]);
        Sum(grid, i, j + 1, sum + grid[i][j]);
    }
}