/*
https://leetcode.com/problems/n-queens/
The n-queens puzzle is the problem of placing n queens on an n x n chessboard such that no two queens attack each other.

Given an integer n, return all distinct solutions to the n-queens puzzle.

Each solution contains a distinct board configuration of the n-queens' placement, where 'Q' and '.' both indicate a queen and an empty space, respectively.

 

Example 1:


Input: n = 4
Output: [[".Q..","...Q","Q...","..Q."],["..Q.","Q...","...Q",".Q.."]]
Explanation: There exist two distinct solutions to the 4-queens puzzle as shown above
Example 2:

Input: n = 1
Output: [["Q"]]
 

Constraints:

1 <= n <= 9
*/
using System;
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