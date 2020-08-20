using System;

class AVLTree
{
    internal class AVLNode
    {
        public int value;
        public int height;
        public AVLNode left;
        public AVLNode right;
        public AVLNode(int value)
        {
            this.value = value;
        }
    }

    public AVLNode root;
    public void Insert(int value)
    {
        root = Insert(root, value);
    }

    private AVLNode Insert(AVLNode node, int value)
    {
        if (node == null)
        {
            return new AVLNode(value);
        }

        if (value > node.value)
        {
            node.right = Insert(node.right, value);
        }
        else
        {
            node.left = Insert(node.left, value);
        }

        root.height = Math.Max(Height(root.left), Height(root.right)) + 1;

        int balanceFactor = BalanceFactor(root);

        Balance(root);
        return node;
    }

    private int Height(AVLNode node)
    {
        return node == null ? -1 : node.height;
    }

    private bool IsLeftHeavy(AVLNode node)
    {
        return BalanceFactor(node) > 1;
    }

    private bool IsRightHeavy(AVLNode node)
    {
        return BalanceFactor(node) < -1;
    }

    private int BalanceFactor(AVLNode node)
    {
        return node == null ? 0 : Height(node.left) - Height(node.right);
    }

    private void Balance(AVLNode node)
    {
        if (IsLeftHeavy(root))
        {
            Console.WriteLine("left");
        }
        else if (IsRightHeavy(root))
        {
            Console.WriteLine("right");
        }
    }
}