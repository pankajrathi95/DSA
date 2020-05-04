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
}