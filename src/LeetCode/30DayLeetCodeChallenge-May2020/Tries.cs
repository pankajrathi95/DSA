/*
Implement a trie with insert, search, and startsWith methods.

Example:

Trie trie = new Trie();

trie.insert("apple");
trie.search("apple");   // returns true
trie.search("app");     // returns false
trie.startsWith("app"); // returns true
trie.insert("app");   
trie.search("app");     // returns true
Note:

You may assume that all inputs are consist of lowercase letters a-z.
All inputs are guaranteed to be non-empty strings.
*/

using System.Collections.Generic;

public class Tries
{
    public class Node
    {
        public char value;
        public bool isEndOfWord;
        public Dictionary<char, Node> children = new Dictionary<char, Node>();

        public Node(char value)
        {
            this.value = value;
        }
    }

    public Node root;
    /** Initialize your data structure here. */
    public Tries()
    {
        root = new Node(' ');
    }

    /** Inserts a word into the trie. */
    public void Insert(string word)
    {
        var current = root;

        foreach (char ch in word)
        {
            if (current.children.ContainsKey(ch))
            {
                current = current.children[ch];
            }
            else
            {
                current.children.Add(ch, new Node(ch));
                current = current.children[ch];
            }
        }

        current.isEndOfWord = true;
    }

    /** Returns if the word is in the trie. */
    public bool Search(string word)
    {
        var current = root;
        foreach (char ch in word)
        {
            if (!current.children.ContainsKey(ch))
            {
                return false;
            }

            current = current.children[ch];
        }

        return current.isEndOfWord;
    }

    /** Returns if there is any word in the trie that starts with the given prefix. */
    public bool StartsWith(string prefix)
    {
        var current = root;
        foreach (char ch in prefix)
        {
            if (!current.children.ContainsKey(ch))
            {
                return false;
            }

            current = current.children[ch];
        }

        return true;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */
