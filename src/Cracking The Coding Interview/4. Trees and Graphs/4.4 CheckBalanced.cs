using System;

public class CheckBalanced
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    // Inefficient Solution
    public bool CheckIfBalanced(TreeNode root)
    {
        if (root == null)
        {
            return true;
        }

        int heightDiff = GetHeight(root.left) - GetHeight(root.right);
        if (Math.Abs(heightDiff) > 1)
        {
            return false;
        }
        else
        {
            return CheckIfBalanced(root.left) && CheckIfBalanced(root.right);
        }
    }

    private int GetHeight(TreeNode root)
    {
        if (root == null)
        {
            return -1;
        }


        return 1 + Math.Max(GetHeight(root.left), GetHeight(root.right));
    }

    public bool CheckBalancedTree(TreeNode root)
    {
        return CheckIfTreeBalanced(root) != Int32.MinValue;
    }
    private int CheckIfTreeBalanced(TreeNode root)
    {
        if (root == null)
            return -1;
        int leftHeight = CheckIfTreeBalanced(root.left);
        if (leftHeight == Int32.MinValue)
        {
            return Int32.MinValue;
        }
        int rightHeight = CheckIfTreeBalanced(root.right);
        if (rightHeight == Int32.MinValue)
        {
            return Int32.MinValue;
        }
        int height = leftHeight - rightHeight;
        if (Math.Abs(height) > 1)
        {
            return Int32.MinValue;
        }
        else
        {
            return Math.Max(leftHeight, rightHeight) + 1;
        }
    }
}