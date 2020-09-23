/*
https://leetcode.com/problems/n-queens-ii/
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