/*
#221 - https://leetcode.com/problems/maximal-square/
Given a 2D binary matrix filled with 0's and 1's, find the largest square containing only 1's and return its area.

Example:

Input: 

1 0 1 0 0
1 0 1 1 1
1 1 1 1 1
1 0 0 1 0

Output: 4
*/

using System;

class MaximalSquare
{
    public int FindMaximalSquare(char[][] matrix)
    {
        int res = 0;
        if (matrix.Length == 0)
            return 0;
        int[][] num = new int[matrix.Length][];

        for (int i = 0; i < matrix.Length; i++)
        {
            num[i] = new int[matrix[0].Length];
            for (int j = 0; j < matrix[0].Length; j++)
            {
                num[i][j] = matrix[i][j] - '0';
            }
        }
        for (int i = 0; i < num.Length; i++)
        {
            for (int j = 0; j < num[0].Length; j++)
            {
                if (i == 0 || j == 0)
                {
                    if (num[i][j] > res)
                    {
                        res = num[i][j];
                    }
                }
                else if (num[i][j] == 1)
                {
                    num[i][j] = Math.Min(num[i - 1][j - 1], Math.Min(num[i - 1][j], num[i][j - 1])) + 1;
                    if (num[i][j] > res)
                    {
                        res = num[i][j];
                    }
                }
            }
        }
        return res * res;
    }
}