/*
https://leetcode.com/problems/word-search-ii/
Given a 2D board and a list of words from the dictionary, find all words in the board.

Each word must be constructed from letters of sequentially adjacent cell, where "adjacent" cells are those horizontally or vertically neighboring. The same letter cell may not be used more than once in a word.

 

Example:

Input: 
board = [
  ['o','a','a','n'],
  ['e','t','a','e'],
  ['i','h','k','r'],
  ['i','f','l','v']
]
words = ["oath","pea","eat","rain"]

Output: ["eat","oath"]
 

Note:

All inputs are consist of lowercase letters a-z.
The values of words are distinct.
*/

using System;
using System.Collections.Generic;
using System.Linq;

public class WordSearchII
{
    HashSet<string> result = new HashSet<string>();
    //Timeout exception
    public IList<string> FindWords(char[][] board, string[] words)
    {
        HashSet<string> wordList = new HashSet<string>();
        int max = 0;
        foreach (var word in words)
        {
            max = Math.Max(max, word.Length);
            wordList.Add(word);
            Console.WriteLine(word);
        }

        bool[][] visited = new bool[board.Length][];
        for (int i = 0; i < visited.Length; i++)
        {
            visited[i] = new bool[board[0].Length];
        }

        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board.Length; j++)
            {
                FindWords(board, wordList, visited, i, j, "", max);
            }
        }

        return result.ToList();
    }

    private void FindWords(char[][] board, HashSet<string> wordList, bool[][] visited, int i, int j, string str, int max)
    {
        if (i < 0 || j < 0 || i >= board.Length || j >= board[i].Length || visited[i][j] || str.Length > max)
        {
            return;
        }



        visited[i][j] = true;
        str = str + board[i][j];
        if (wordList.Contains(str))
        {
            result.Add(str);
        }

        FindWords(board, wordList, visited, i + 1, j, new String(str), max);
        FindWords(board, wordList, visited, i, j + 1, new String(str), max);
        FindWords(board, wordList, visited, i - 1, j, new String(str), max);
        FindWords(board, wordList, visited, i, j - 1, new String(str), max);

        visited[i][j] = false;
    }
}