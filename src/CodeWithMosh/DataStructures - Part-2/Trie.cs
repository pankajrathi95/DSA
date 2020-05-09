using System;
using System.Collections.Generic;
using System.Text;

public class Trie
{
    public class Node
    {
        public char value;
        public Dictionary<char, Node> children = new Dictionary<char, Node>();
        public bool isEndOfWord;
        public Node(char value)
        {
            this.value = value;
        }

        public bool HasChild(char ch)
        {
            return children.ContainsKey(ch);
        }

        public void AddChild(char ch)
        {
            children.Add(ch, new Node(ch));
        }

        public Node GetChild(char ch)
        {
            if (!children.ContainsKey(ch))
            {
                return null;
            }
            return children[ch];
        }

        public Dictionary<char, Node> GetChildren()
        {
            return children;
        }

        public void RemoveChild(char ch)
        {
            children.Remove(ch);
        }
    }
    Node root = new Node(' ');
    public void Insert(string word)
    {
        var current = root;
        foreach (char ch in word)
        {
            if (!current.HasChild(ch))
            {
                current.AddChild(ch);
            }

            current = current.GetChild(ch);
        }

        current.isEndOfWord = true;
    }

    public bool Contains(string word)
    {
        if (word == null)
        {
            return false;
        }

        var current = root;
        foreach (char ch in word)
        {
            if (!current.HasChild(ch))
            {
                return false;
            }

            current = current.GetChild(ch);
        }

        return current.isEndOfWord;
    }

    public void Traverse()
    {
        Traverse(root);
    }

    private void Traverse(Node node)
    {
        Console.WriteLine(node.value);
        foreach (var child in node.GetChildren())
        {
            Traverse(child.Value);
        }
    }

    public void Remove(string word)
    {
        Remove(root, word, 0);
    }

    public void Remove(Node node, string word, int index)
    {
        if (index == word.Length)
        {
            node.isEndOfWord = false;
            return;
        }

        var ch = word[index];
        var child = node.GetChild(ch);

        if (child == null)
        {
            return;
        }

        Remove(child, word, index + 1);

        if (child.children.Count == 0 && !child.isEndOfWord)
        {
            child.RemoveChild(ch);
        }
    }

    public List<string> AutoComplete(string word)
    {
        List<string> words = new List<string>();

        var current = root;
        foreach (char ch in word)
        {
            var child = current.GetChild(ch);

            if (child == null)
            {
                return null;
            }

            current = child;
        }

        AutoComplete(current, word, words);
        return words;
    }

    private void AutoComplete(Node node, string word, List<string> words)
    {
        if (node.isEndOfWord)
        {
            words.Add(word);
        }

        foreach (var child in node.GetChildren())
        {
            AutoComplete(child.Value, word + child.Value.value, words);
        }
    }

    public bool ContainsRecursive(string word)
    {
        return ContainsRecursive(root, 0, word);
    }

    private bool ContainsRecursive(Node node, int i, string word)
    {
        if (i == word.Length)
            return root.isEndOfWord;

        if (root == null)
            return false;

        var ch = word[i];
        var child = root.GetChild(ch);
        if (child == null)
            return false;

        return ContainsRecursive(child, i + 1, word);
    }

    public int CountWords()
    {
        int count = 0;
        count = CountWords(root);
        return count;
    }

    private int CountWords(Node node)
    {
        int count = 0;
        if (node == null)
        {
            return count;
        }

        if (node.isEndOfWord)
        {
            count = count + 1;
        }

        foreach (var child in node.GetChildren())
        {
            count += CountWords(child.Value);
        }

        return count;
    }

    public static string LongestCommonPrefix(string[] words)
    {
        Trie trie = new Trie();
        foreach (var word in words)
        {
            trie.Insert(word);
        }

        var maxChars = GetShortestWord(words).Length;
        var prefix = new StringBuilder();
        var current = trie.root;
        while (prefix.Length < maxChars)
        {
            var children = current.GetChildren();

            if (children.Count != 1)
            {
                break;
            }
            var temp = new Node[maxChars];
            children.Values.CopyTo(temp, 0);
            current = temp[0];
            prefix.Append(current.value);
        }

        return prefix.ToString();
    }

    private static string GetShortestWord(string[] words)
    {
        if (words == null || words.Length == 0)
        {
            return string.Empty;
        }

        var shortest = words[0];
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length < shortest.Length)
            {
                shortest = words[i];
            }
        }

        return shortest;
    }
}