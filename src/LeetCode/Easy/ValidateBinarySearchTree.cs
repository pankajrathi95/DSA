/*
https://leetcode.com/problems/validate-binary-search-tree/
*/


using System;
/**
* Definition for a binary tree node.
* public class TreeNode {
*     public int val;
*     public TreeNode left;
*     public TreeNode right;
*     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
*         this.val = val;
*         this.left = left;
*         this.right = right;
*     }
* }
*/
public class ValidateBinarySearchTree
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
        return IsValidBST(root, null, null);
    }

    private bool IsValidBST(TreeNode root, Nullable<int> min, Nullable<int> max)
    {
        if (root == null)
        {
            return true;
        }
        else if ((max != null && root.val >= max) || (min != null && root.val <= min))
        {
            return false;
        }

        return IsValidBST(root.left, min, root.val) && IsValidBST(root.right, root.val, max);
    }
}