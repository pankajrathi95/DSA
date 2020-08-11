/*

*/

using System.Collections.Generic;

public class ValidSudoku
{
    public bool IsValidSudoku(char[][] board)
    {
        for (int i = 0; i < board.Length; i++)
        {
            HashSet<char> cols = new HashSet<char>();
            HashSet<char> rows = new HashSet<char>();
            for (int j = 0; j < board[i].Length; j++)
            {
                if (board[i][j] != '.')
                {
                    if (!cols.Contains(board[i][j]))
                    {
                        cols.Add(board[i][j]);
                    }
                    else
                    {
                        return false;
                    }
                }

                if (board[j][i] != '.')
                {
                    if (!rows.Contains(board[j][i]))
                    {
                        rows.Add(board[j][i]);
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                HashSet<char> grid = new HashSet<char>();
                for (int k = 0; k < 3; k++)
                {
                    for (int l = 0; l < 3; l++)
                    {
                        if (board[k + i * 3][l + j * 3] == '.') continue;
                        if (!grid.Contains(board[k + i * 3][l + j * 3]))
                        {
                            grid.Add(board[k + i * 3][l + j * 3]);
                        }
                        else
                        {
                            return false;
                        }
                    }
                }

            }
        }

        return true;
    }
}