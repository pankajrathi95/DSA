/*
https://leetcode.com/problems/binary-tree-inorder-traversal
*/

using System.Collections.Generic;

public class BinaryTreeInorderTraversal
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
    public IList<int> InorderTraversal(TreeNode root)
    {
        IList<int> result = new List<int>();
        Inorder(root, result);
        return result;
    }

    private void Inorder(TreeNode root, IList<int> result)
    {
        if (root == null)
        {
            return;
        }

        Inorder(root.left, result);
        result.Add(root.val);
        Inorder(root.right, result);
    }
}