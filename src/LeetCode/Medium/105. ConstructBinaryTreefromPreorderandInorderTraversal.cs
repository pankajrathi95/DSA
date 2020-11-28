/*
https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/

Given preorder and inorder traversal of a tree, construct the binary tree.

Note:
You may assume that duplicates do not exist in the tree.

For example, given

preorder = [3,9,20,15,7]
inorder = [9,3,15,20,7]
Return the following binary tree:

    3
   / \
  9  20
    /  \
   15   7
*/


using System.Collections.Generic;
public class ConstructBinaryTreefromPreorderandInorderTraversal
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
    Dictionary<int, int> hm = new Dictionary<int, int>();
    int preOrderIndex = 0;
    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        for (int i = 0; i < inorder.Length; i++)
        {
            hm.Add(inorder[i], i);
        }

        return BuildTree(preorder, inorder, 0, inorder.Length - 1);
    }

    private TreeNode BuildTree(int[] preorder, int[] inorder, int start, int end)
    {
        if (start > end)
        {
            return null;
        }

        TreeNode root = new TreeNode(preorder[preOrderIndex++]);

        if (root == null)
        {
            return null;
        }

        if (start == end)
        {
            return root;
        }

        int index = hm[root.val];
        root.left = BuildTree(preorder, inorder, start, index - 1);
        root.right = BuildTree(preorder, inorder, index + 1, end);

        return root;
    }
}