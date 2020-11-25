/*
https://leetcode.com/problems/n-queens-ii/

The n-queens puzzle is the problem of placing n queens on an n x n chessboard such that no two queens attack each other.

Given an integer n, return the number of distinct solutions to the n-queens puzzle.

 

Example 1:


Input: n = 4
Output: 2
Explanation: There are two distinct solutions to the 4-queens puzzle as shown.
Example 2:

Input: n = 1
Output: 1
 

Constraints:

1 <= n <= 9
*/

using System;
using System.Collections.Generic;

public class NQueensII
{
    int count = 0;
    public int TotalNQueens(int n)
    {
        SolveNQueens(n, 0, new List<int>());
        return count;
    }

    private void SolveNQueens(int n, int row, List<int> colPlacement)
    {
        if (row == n)
        {
            count++;
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                colPlacement.Add(i);
                if (IsValid(colPlacement))
                {
                    SolveNQueens(n, row + 1, colPlacement);
                }

                colPlacement.RemoveAt(colPlacement.Count - 1);
            }
        }
    }

    private bool IsValid(List<int> colPlacement)
    {
        int rowId = colPlacement.Count - 1;
        for (int i = 0; i < rowId; i++)
        {
            int diff = Math.Abs(colPlacement[i] - colPlacement[rowId]);
            if (diff == 0 || diff == rowId - i)
            {
                return false;
            }
        }

        return true;
    }
}