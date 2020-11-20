/*
https://leetcode.com/problems/search-suggestions-system/

*/

using System;
using System.Collections.Generic;

public class SearchSuggestionsSystem
{
    public class Node
    {
        public char value;
        public Dictionary<char, Node> children = new Dictionary<char, Node>();
        public IList<string> words = new List<string>();
        public bool isEndOfWord = false;

        public Node(char value)
        {
            this.value = value;
        }

        public bool HasChild(char value)
        {
            return children.ContainsKey(value);
        }

        public void AddChild(char value)
        {
            children.Add(value, new Node(value));
        }
    }

    Node root = new Node(' ');
    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
    {
        IList<IList<string>> result = new List<IList<string>>();
        Array.Sort(products);
        foreach (var product in products)
        {
            var current = root;
            foreach (var ch in product)
            {
                if (!current.HasChild(ch))
                {
                    current.AddChild(ch);
                }

                current = current.children[ch];
                if (current.words.Count < 3)
                    current.words.Add(product);
            }

            current.isEndOfWord = true;

        }

        var curr = root;
        foreach (var search in searchWord)
        {
            if (curr.HasChild(search))
            {
                curr = curr.children[search];
            }

            result.Add(curr.words);
        }

        return result;
    }
}