/*
https://leetcode.com/problems/longest-increasing-path-in-a-matrix/

Given an m x n integers matrix, return the length of the longest increasing path in matrix.

From each cell, you can either move in four directions: left, right, up, or down. You may not move diagonally or move outside the boundary (i.e., wrap-around is not allowed).

 

Example 1:


Input: matrix = [[9,9,4],[6,6,8],[2,1,1]]
Output: 4
Explanation: The longest increasing path is [1, 2, 6, 9].
Example 2:


Input: matrix = [[3,4,5],[3,2,6],[2,2,1]]
Output: 4
Explanation: The longest increasing path is [3, 4, 5, 6]. Moving diagonally is not allowed.
Example 3:

Input: matrix = [[1]]
Output: 1
 

Constraints:

m == matrix.length
n == matrix[i].length
1 <= m, n <= 200
0 <= matrix[i][j] <= 231 - 1
*/

using System;
public class LongestIncreasingPathinaMatrix
{
    public int LongestIncreasingPath(int[][] matrix)
    {
        int m = matrix.Length, n = matrix[0].Length;
        int[][] dp = new int[m][];
        for (int i = 0; i < m; i++)
        {
            dp[i] = new int[n];
        }

        int max = 1;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                max = Math.Max(max, Dfs(matrix, m, n, i, j, dp));
            }
        }

        return max;
    }

    private int Dfs(int[][] matrix, int m, int n, int i, int j, int[][] dp)
    {
        int max = 1;
        if (dp[i][j] != 0)
        {
            return dp[i][j];
        }

        if (i + 1 < m && matrix[i + 1][j] > matrix[i][j])
        {
            max = Math.Max(max, 1 + Dfs(matrix, m, n, i + 1, j, dp));
        }

        if (j + 1 < n && matrix[i][j + 1] > matrix[i][j])
        {
            max = Math.Max(max, 1 + Dfs(matrix, m, n, i, j + 1, dp));
        }

        if (i - 1 >= 0 && matrix[i - 1][j] > matrix[i][j])
        {
            max = Math.Max(max, 1 + Dfs(matrix, m, n, i - 1, j, dp));
        }

        if (j - 1 >= 0 && matrix[i][j - 1] > matrix[i][j])
        {
            max = Math.Max(max, 1 + Dfs(matrix, m, n, i, j - 1, dp));
        }

        return dp[i][j] = max;
    }
}