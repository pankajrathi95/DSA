using System;
using System.Collections.Generic;

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
}