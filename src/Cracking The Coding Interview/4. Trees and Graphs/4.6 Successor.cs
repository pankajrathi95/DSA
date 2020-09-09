using System;

public class Successor
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        internal TreeNode parent;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public TreeNode InorderSucc(TreeNode n)
    {
        if (n == null)
        {
            return null;
        }

        if (n.right != null)
        {
            return LeftMostNode(n);
        }
        else
        {
            TreeNode q = n;
            TreeNode x = q.parent;
            while (x != null && x.left != q)
            {
                q = x;
                x = x.parent;
            }

            return x;
        }
    }

    private TreeNode LeftMostNode(TreeNode n)
    {
        while (n.left != null)
        {
            n = n.left;
        }

        return n;
    }
}