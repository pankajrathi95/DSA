using System;
using System.Collections.Generic;

public class EightQueens
{
    public List<List<int>> Queen(int n)
    {
        List<List<int>> result = new List<List<int>>();
        SolveNQueen(n, 0, new List<int>(), result);
        return result;
    }

    private void SolveNQueen(int n, int row, List<int> colPlacements, List<List<int>> result)
    {
        if (row == n)
        {
            result.Add(new List<int>(colPlacements));
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                colPlacements.Add(i);
                if (IsValid(colPlacements))
                {
                    SolveNQueen(n, row + 1, colPlacements, result);
                }
                colPlacements.RemoveAt(colPlacements.Count - 1);
            }
        }
    }

    private bool IsValid(List<int> colPlacements)
    {
        int rowId = colPlacements.Count - 1;
        for (int i = 0; i < rowId; i++)
        {
            int diff = Math.Abs(colPlacements[i] - colPlacements[rowId]);
            if (diff == 0 || diff == rowId - i)
            {
                return false;
            }
        }

        return true;
    }
}