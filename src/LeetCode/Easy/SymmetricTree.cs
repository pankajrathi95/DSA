/*
https://leetcode.com/problems/symmetric-tree/
*/
public class SymmetricTree
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
    public bool IsSymmetric(TreeNode root)
    {
        if (root == null)
        {
            return true;
        }

        return IsSymmetric(root.left, root.right);
    }

    private bool IsSymmetric(TreeNode left, TreeNode right)
    {
        if ((left == null && right != null) || (left != null && right == null))
        {
            return false;
        }

        if (left == null)
        {
            return true;
        }

        if (right == null)
        {
            return true;
        }

        if (left.val != right.val)
        {
            return false;
        }

        return IsSymmetric(left.left, right.right) && IsSymmetric(left.right, right.left);
    }
}