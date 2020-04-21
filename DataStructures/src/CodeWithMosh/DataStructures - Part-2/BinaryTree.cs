using System;

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

        if (root.left == null && root.right == null)
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
        if (root.left == null && root.right == null)
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

    public void PrintNodesAtDistance(int length)
    {
        PrintNodesAtDistance(root, length);
    }

    private void PrintNodesAtDistance(Node root, int length)
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

        PrintNodesAtDistance(root.left, length--);
        PrintNodesAtDistance(root.right, length - 1);
    }
}