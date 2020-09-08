using System;

public class ValidateBST
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

    public bool IsValidBST(TreeNode root)
    {
        return IsValidBST(root, Int32.MinValue, Int32.MaxValue);
    }

    private bool IsValidBST(TreeNode root, int min, int max)
    {
        if (root == null)
        {
            return true;
        }

        if (root.val < min || root.val > max)
        {
            return false;
        }

        return IsValidBST(root.left, min, root.val - 1) && IsValidBST(root.right, root.val + 1, max);
    }
}