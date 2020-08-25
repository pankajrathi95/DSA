/*
Implement the StreamChecker class as follows:

StreamChecker(words): Constructor, init the data structure with the given words.
query(letter): returns true if and only if for some k >= 1, the last k characters queried (in order from oldest to newest, including this letter just queried) spell one of the words in the given list.
 

Example:

StreamChecker streamChecker = new StreamChecker(["cd","f","kl"]); // init the dictionary.
streamChecker.query('a');          // return false
streamChecker.query('b');          // return false
streamChecker.query('c');          // return false
streamChecker.query('d');          // return true, because 'cd' is in the wordlist
streamChecker.query('e');          // return false
streamChecker.query('f');          // return true, because 'f' is in the wordlist
streamChecker.query('g');          // return false
streamChecker.query('h');          // return false
streamChecker.query('i');          // return false
streamChecker.query('j');          // return false
streamChecker.query('k');          // return false
streamChecker.query('l');          // return true, because 'kl' is in the wordlist
 

Note:

1 <= words.length <= 2000
1 <= words[i].length <= 2000
Words will only consist of lowercase English letters.
Queries will only consist of lowercase English letters.
The number of queries is at most 40000.
   Hide Hint #1  
Put the words into a trie, and manage a set of pointers within that trie.
*/

using System.Collections.Generic;
using System.Text;

public class StreamofCharacters
{
    StringBuilder sb = new StringBuilder();
    public class Trie
    {
        public Dictionary<char, Trie> children = new Dictionary<char, Trie>();
        public bool isEndOfWord;
        public char value;

        public Trie(char ch)
        {
            this.value = ch;
        }
    }
    Trie root;
    public StreamofCharacters(string[] words)
    {
        root = new Trie(' ');
        foreach (var word in words)
        {
            AddChildren(word);
        }
    }

    public void AddChildren(string word)
    {
        var current = root;
        for (int i = word.Length - 1; i >= 0; i--)
        {
            if (!current.children.ContainsKey(word[i]))
            {
                current.children.Add(word[i], new Trie(word[i]));
            }

            current = current.children[word[i]];
        }

        current.isEndOfWord = true;
    }

    public bool Query(char letter)
    {
        var node = root;
        sb.Append(letter);
        for (int i = sb.Length - 1; i >= 0; i--)
        {
            if (node.children.ContainsKey(sb[i]) && node.children[sb[i]].isEndOfWord)
            {
                return true;
            }

            if (!node.children.ContainsKey(sb[i]))
            {
                return false;
            }

            node = node.children[sb[i]];
        }

        return false;
    }
}

/**
 * Your StreamofCharacters object will be instantiated and called as such:
 * StreamofCharacters obj = new StreamofCharacters(words);
 * bool param_1 = obj.Query(letter);
 */