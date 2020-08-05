/*
Design a data structure that supports the following two operations:

void addWord(word)
bool search(word)
search(word) can search a literal word or a regular expression string containing only letters a-z or .. A . means it can represent any one letter.

Example:

addWord("bad")
addWord("dad")
addWord("mad")
search("pad") -> false
search("bad") -> true
search(".ad") -> true
search("b..") -> true
Note:
You may assume that all words are consist of lowercase letters a-z.
*/

using System.Collections.Generic;

public class WordDictionary
{

    public class Trie
    {
        public char val;
        public bool isWord;
        public Dictionary<char, Trie> children = new Dictionary<char, Trie>();
        public Trie(char val)
        {
            this.val = val;
        }
    }

    Trie root;
    /** Initialize your data structure here. */
    public WordDictionary()
    {
        root = new Trie(' ');
    }

    /** Adds a word into the data structure. */
    public void AddWord(string word)
    {
        var current = root;
        foreach (var ch in word)
        {
            if (!current.children.ContainsKey(ch))
            {
                current.children.Add(ch, new Trie(ch));
            }

            current = current.children[ch];
        }

        current.isWord = true;
    }

    /** Returns if the word is in the data structure. A word could contain the dot character '.' to represent any one letter. */
    public bool Search(string word)
    {
        return Search(word, 0, root);
    }

    private bool Search(string word, int index, Trie node)
    {
        if (index == word.Length)
        {
            return node.isWord;
        }

        if (word[index] == '.')
        {
            foreach (var kvp in node.children)
            {
                if (Search(word, index + 1, node.children[kvp.Key]))
                {
                    return true;
                }
            }
        }
        else
        {
            if (node.children.ContainsKey(word[index]) && Search(word, index + 1, node.children[word[index]]))
            {
                return true;
            }
        }

        return false;
    }

}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */