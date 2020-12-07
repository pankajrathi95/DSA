/*
https://leetcode.com/problems/minimum-absolute-difference-in-bst/
Given a binary search tree with non-negative values, find the minimum absolute difference between values of any two nodes.

Example:

Input:

   1
    \
     3
    /
   2

Output:
1

Explanation:
The minimum absolute difference is 1, which is the difference between 2 and 1 (or between 2 and 3).
 

Note:

There are at least two nodes in this BST.
This question is the same as 783: https://leetcode.com/problems/minimum-distance-between-bst-nodes/
*/


using System;

public class MinimumAbsoluteDifferenceinBST
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
    int res = Int32.MaxValue, pre = -1;
    public int GetMinimumDifference(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        if (root.left != null)
        {
            GetMinimumDifference(root.left);
        }

        if (pre != -1)
        {
            res = Math.Min(res, root.val - pre);
        }

        pre = root.val;
        if (root.right != null)
        {
            GetMinimumDifference(root.right);
        }

        return res;
    }
}