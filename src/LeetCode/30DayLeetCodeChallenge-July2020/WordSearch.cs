/*
Given a 2D board and a word, find if the word exists in the grid.

The word can be constructed from letters of sequentially adjacent cell, where "adjacent" cells are those horizontally or vertically neighboring. The same letter cell may not be used more than once.

Example:

board =
[
  ['A','B','C','E'],
  ['S','F','C','S'],
  ['A','D','E','E']
]

Given word = "ABCCED", return true.
Given word = "SEE", return true.
Given word = "ABCB", return false.
 

Constraints:

board and word consists only of lowercase and uppercase English letters.
1 <= board.length <= 200
1 <= board[i].length <= 200
1 <= word.length <= 10^3
*/

public class WordSearch
{
    public bool Exist(char[][] board, string word)
    {
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[i].Length; j++)
            {
                if (board[i][j] == word[0] && CheckTheBoard(board, i, j, 0, word))
                {
                    return true;
                }
            }
        }

        return false;
    }

    private bool CheckTheBoard(char[][] board, int i, int j, int count, string word)
    {
        if (count == word.Length)
        {
            return true;
        }

        if (i < 0 || i >= board.Length || j < 0 || j >= board[i].Length || board[i][j] != word[count])
        {
            return false;
        }

        char temp = board[i][j];
        board[i][j] = ' ';
        bool found = CheckTheBoard(board, i + 1, j, count + 1, word) ||
        CheckTheBoard(board, i - 1, j, count + 1, word) ||
        CheckTheBoard(board, i, j + 1, count + 1, word) ||
        CheckTheBoard(board, i, j - 1, count + 1, word);

        board[i][j] = temp;
        return found;
    }
}