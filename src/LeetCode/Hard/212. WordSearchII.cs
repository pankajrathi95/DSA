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

using System.Collections.Generic;
using System.Linq;
public class WordSearchII
{
    public class TrieNode
    {
        public char value;
        public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
        public bool isEndOfWord;
        public TrieNode(char value)
        {
            this.value = value;
        }
    }

    public void Insert(string s)
    {
        var current = root;
        foreach (var ch in s)
        {
            if (!current.children.ContainsKey(ch))
            {
                current.children.Add(ch, new TrieNode(ch));
            }

            current = current.children[ch];
        }

        current.isEndOfWord = true;
    }

    private void BuildTrie(string[] words)
    {
        foreach (var word in words)
        {
            Insert(word);
        }
    }

    TrieNode root = new TrieNode(' ');
    public IList<string> FindWords(char[][] board, string[] words)
    {
        BuildTrie(words);
        bool[][] visited = new bool[board.Length][];
        for (int i = 0; i < visited.Length; i++)
        {
            visited[i] = new bool[board[0].Length];
        }

        HashSet<string> result = new HashSet<string>();
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[i].Length; j++)
            {
                if (root.children.ContainsKey(board[i][j]))
                {
                    Dfs(board, visited, i, j, result, root, "");
                }
            }
        }

        return result.ToList();
    }

    private void Dfs(char[][] board, bool[][] visited, int i, int j, HashSet<string> result, TrieNode current, string str)
    {
        if (i < 0 || j < 0 || i >= board.Length || j >= board[i].Length || visited[i][j] || !current.children.ContainsKey(board[i][j]))
        {
            return;
        }

        visited[i][j] = true;
        current = current.children[board[i][j]];
        str += board[i][j];
        if (current.isEndOfWord && !result.Contains(str))
        {
            result.Add(str);
        }
        Dfs(board, visited, i + 1, j, result, current, str);
        Dfs(board, visited, i, j + 1, result, current, str);
        Dfs(board, visited, i - 1, j, result, current, str);
        Dfs(board, visited, i, j - 1, result, current, str);
        str.Remove(str.Length - 1);
        visited[i][j] = false;
    }
}






