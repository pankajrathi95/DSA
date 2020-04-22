using System;
using System.Collections;
using System.Collections.Generic;

class BinaryTree
{
    public class Node
    {
        public int value;
        public Node left;
        public Node right;
        public Node(int value)
        {
            this.value = value;
        }
    }

    public Node root;

    public void Insert(int value)
    {
        if (root == null)
        {
            root = new Node(value);
            return;
        }
        Node current = root;
        while (true)
        {
            if (value > current.value)
            {
                if (current.right == null)
                {
                    current.right = new Node(value);
                    break;
                }

                current = current.right;
            }
            else
            {
                if (current.left == null)
                {
                    current.left = new Node(value);
                    break;
                }

                current = current.left;
            }
        }

        current = new Node(value);
    }

    public bool Find(int value)
    {
        var current = root;
        while (current != null)
        {
            if (value < current.value)
            {
                current = current.left;
            }
            else if (value > current.value)
            {
                current = current.right;
            }
            else
            {
                return true;
            }
        }

        return false;
    }

    public void PreOrderTraversal()
    {
        PreOrderTraversal(root);
    }

    private void PreOrderTraversal(Node root)
    {
        if (root == null)
        {
            return;
        }

        Console.WriteLine(root.value);
        PreOrderTraversal(root.left);
        PreOrderTraversal(root.right);
    }

    public void InOrderTraversal()
    {
        InOrderTraversal(root);
    }

    private void InOrderTraversal(Node root)
    {
        if (root == null)
        {
            return;
        }
        InOrderTraversal(root.left);
        Console.WriteLine(root.value);
        InOrderTraversal(root.right);
    }
    public void PostOrderTraversal()
    {
        PostOrderTraversal(root);
    }

    private void PostOrderTraversal(Node root)
    {
        if (root == null)
        {
            return;
        }

        PostOrderTraversal(root.left);
        PostOrderTraversal(root.right);
        Console.WriteLine(root.value);
    }

    public int Height()
    {
        return Height(root);
    }

    private int Height(Node root)
    {
        if (root == null)
        {
            return -1;
        }

        if (IsLeafNode(root))
        {
            return 0;
        }

        return 1 + Math.Max(Height(root.left), Height(root.right));
    }

    public int Min()
    {
        return Min(root);
    }

    private int Min(Node root)
    {
        if (IsLeafNode(root))
        {
            return root.value;
        }
        var left = Min(root.left);
        var right = Min(root.right);

        return Math.Min(Math.Min(left, right), root.value);
    }

    public bool Equals(BinaryTree other)
    {
        return Equals(root, other.root);
    }

    private bool Equals(Node node1, Node node2)
    {
        if (node1 == null && node2 == null)
        {
            return true;
        }

        if (node1 != null && node2 != null)
        {
            return node1.value == node2.value && Equals(node1.left, node2.left) && Equals(node1.right, node2.right);
        }

        return false;
    }

    public bool IsBinarySearchTree()
    {
        return IsBinarySearchTree(root, int.MinValue, int.MaxValue);
    }

    private bool IsBinarySearchTree(Node root, int min, int max)
    {
        if (root == null)
        {
            return true;
        }

        if (root.value < min || root.value > max)
        {
            return false;
        }

        return IsBinarySearchTree(root.left, min, root.value - 1) && IsBinarySearchTree(root.right, root.value + 1, max);
    }

    public IList<int> GetNodesAtDistance(int length)
    {
        var list = new List<int>();
        GetNodesAtDistance(root, length, list);
        return list;
    }

    private void GetNodesAtDistance(Node root, int length, IList<int> list)
    {
        if (root == null)
        {
            return;
        }

        if (length == 0)
        {
            Console.WriteLine(root.value);
            return;
        }

        GetNodesAtDistance(root.left, length - 1, list);
        GetNodesAtDistance(root.right, length - 1, list);
    }

    public void TraversalLevelOrder()
    {
        for (int i = 0; i <= Height(); i++)
        {
            foreach (var value in GetNodesAtDistance(i))
            {
                Console.WriteLine(value);
            }
        }
    }

    public int Size()
    {
        return Size(root);
    }

    private int Size(Node root)
    {
        if (root == null)
        {
            return 0;
        }

        if (IsLeafNode(root))
        {
            return 1;
        }

        return 1 + Size(root.left) + Size(root.right);
    }

    public bool IsLeafNode(Node root)
    {
        return root.left == null && root.right == null;
    }

    public int CountLeaves()
    {
        return CountLeaves(root);
    }

    private int CountLeaves(Node root)
    {
        if (root == null)
        {
            return 0;
        }

        if (IsLeafNode(root))
        {
            return 1;
        }

        return CountLeaves(root.left) + CountLeaves(root.right);
    }

    public int Max()
    {
        return Max(root);
    }

    private int Max(Node root)
    {
        if (root == null)
        {
            throw new InvalidOperationException();
        }

        if (root.right == null)
        {
            return root.value;
        }
        else
        {
            return Max(root.right);
        }
    }

    public bool Contains(int value)
    {
        return Contains(root, value);
    }

    private bool Contains(Node root, int value)
    {
        if (root == null)
        {
            return false;
        }

        if (value < root.value)
        {
            return Contains(root.left, value);
        }
        else if (value > root.value)
        {
            return Contains(root.right, value);
        }
        else
        {
            return true;
        }
    }

    public bool AreSiblings(int left, int right)
    {
        return AreSiblings(root, left, right);
    }

    private bool AreSiblings(Node root, int left, int right)
    {
        if (root == null || IsLeafNode(root))
        {
            return false;
        }

        if (root.left.value == left && root.right.value == right)
        {
            return true;
        }

        return AreSiblings(root.left, left, right) || AreSiblings(root.right, left, right);
    }

    public IList<int> GetAncestors(int value)
    {
        List<int> list = new List<int>();
        GetAncestors(root, value, list);
        return list;
    }

    private bool GetAncestors(Node root, int value, IList<int> list)
    {
        if (root == null)
        {
            return false;
        }

        if (value == root.value)
        {
            return true;
        }


        if (GetAncestors(root.left, value, list) || GetAncestors(root.right, value, list))
        {
            list.Add(root.value);
            return true;
        }

        return false;
    }
}