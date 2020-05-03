public class Trie
{
    public class Node
    {
        public char value;
        public Node[] children = new Node[26];
        public bool isEndOfWord;
        public Node(char value)
        {
            this.value = value;
        }
    }
    Node root = new Node('0');
    public void Insert(string word)
    {
        foreach (char ch in word)
        {
            Insert(root, ch);
        }
    }

    private void Insert(Node node, char ch)
    {
        var current = node;
        var index = ch - 'a';
        if (current.children[index] == null)
        {
            current.children[index] = new Node(ch);
        }
    }
}