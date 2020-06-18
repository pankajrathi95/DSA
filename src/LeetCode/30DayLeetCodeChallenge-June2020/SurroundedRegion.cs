/*
Given a 2D board containing 'X' and 'O' (the letter O), capture all regions surrounded by 'X'.

A region is captured by flipping all 'O's into 'X's in that surrounded region.

Example:

X X X X
X O O X
X X O X
X O X X
After running your function, the board should be:

X X X X
X X X X
X X X X
X O X X
Explanation:

Surrounded regions shouldn’t be on the border, which means that any 'O' on the border of the board are not flipped to 'X'. Any 'O' that is not on the border and it is not connected to an 'O' on the border will be flipped to 'X'. Two cells are connected if they are adjacent cells connected horizontally or vertically.
*/

public class SurroundedRegion
{
    public void Solve(char[][] board)
    {
        if (board.Length == 0)
        {
            return;
        }
        int rows = board.Length;
        int cols = board[0].Length;

        for (int i = 0; i < rows; i++)
        {
            if (board[i][0] == 'O')
            {
                CoverTheBoard(board, i, 0);
            }

            if (board[i][cols - 1] == 'O')
            {
                CoverTheBoard(board, i, cols - 1);
            }
        }

        for (int i = 0; i < cols; i++)
        {
            if (board[0][i] == 'O')
            {
                CoverTheBoard(board, 0, i);
            }

            if (board[rows - 1][i] == 'O')
            {
                CoverTheBoard(board, rows - 1, i);
            }
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (board[i][j] == 'O')
                {
                    board[i][j] = 'X';
                }
                else if (board[i][j] == '*')
                {
                    board[i][j] = 'O';
                }
            }
        }
    }

    private void CoverTheBoard(char[][] board, int i, int j)
    {
        if (i < 0 || j < 0 || i > board.Length - 1 || j > board[0].Length - 1)
        {
            return;
        }

        if (board[i][j] == 'O')
        {
            board[i][j] = '*';
        }

        if (i > 0 && board[i - 1][j] == 'O')
        {
            CoverTheBoard(board, i - 1, j);
        }

        if (i < board.Length - 1 && board[i + 1][j] == 'O')
        {
            CoverTheBoard(board, i + 1, j);
        }

        if (j > 0 && board[i][j - 1] == 'O')
        {
            CoverTheBoard(board, i, j - 1);
        }

        if (j < board[0].Length - 1 && board[i][j + 1] == 'O')
        {
            CoverTheBoard(board, i, j + 1);
        }

        return;
    }
}