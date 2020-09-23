/*
https://leetcode.com/problems/n-queens/
*/
using System.Collections.Generic;
using System.Text;

public class NQueens
{
    public IList<IList<string>> SolveNQueens(int n)
    {
        IList<IList<string>> result = new List<IList<string>>();
        SolveNQueens(n, 0, new List<int>(), result);
        return result;
    }

    private void SolveNQueens(int n, int row, List<int> colPlacements, IList<IList<string>> result)
    {
        if (row == n)
        {
            List<string> queens = new List<string>();
            for (int i = 0; i < colPlacements.Count; i++)
            {
                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < n; j++)
                {
                    if (colPlacements[i] == j)
                    {
                        sb.Append('Q');
                    }
                    else
                    {
                        sb.Append('.');
                    }
                }
                queens.Add(sb.ToString());
            }

            result.Add(queens);
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                colPlacements.Add(i);
                if (IsValid(colPlacements))
                {
                    SolveNQueens(n, row + 1, colPlacements, result);
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