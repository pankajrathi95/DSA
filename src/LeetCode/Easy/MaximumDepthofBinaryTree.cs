/*
https://leetcode.com/problems/maximum-depth-of-binary-tree/
*/

public class MaximumDepthofBinaryTree
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
    public int MaxDepth(TreeNode root)
    {
        return Depth(root, 0);
    }

    private int Depth(TreeNode root, int height)
    {
        if (root == null)
        {
            return height;
        }

        return Math.Max(Depth(root.left, height + 1), Depth(root.right, height + 1));
    }
}