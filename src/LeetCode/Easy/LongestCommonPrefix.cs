using System;
using System.Collections.Generic;
using System.Text;

public class LongestCommonPrefix
{
    public class Node
    {
        public char value;
        public Dictionary<char, Node> children = new Dictionary<char, Node>();

        public Node(char value)
        {
            this.value = value;
        }

        public void Insert(string word, Node current)
        {
            foreach (char ch in word)
            {
                if (!current.children.ContainsKey(ch))
                {
                    current.children.Add(ch, new Node(ch));
                }

                current = current.children[ch];
            }
        }
    }

    public Node root = new Node(' ');

    public string FindLongestCommonPrefix(string[] strs)
    {
        var current = root;
        foreach (var str in strs)
        {
            current.Insert(str, current);
        }

        StringBuilder sb = new StringBuilder();
        while (current.children.Count != 0)
        {
            char ch = ' ';
            foreach (var kvp in current.children)
            {
                ch = kvp.Key;
            }

            if (current.children.Count != 1)
            {
                break;
            }

            sb.Append(ch);
            current = current.children[ch];
        }

        return sb.ToString();
    }
}