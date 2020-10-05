/*

Given a binary tree, you need to compute the length of the diameter of the tree. The diameter of a binary tree is the length of the longest path between any two nodes in a tree. This path may or may not pass through the root.

Example:
Given a binary tree
          1
         / \
        2   3
       / \     
      4   5    
Return 3, which is the length of the path [4,2,1,3] or [5,2,1,3].

Note: The length of path between two nodes is represented by the number of edges between them.

*/

/**
* Definition for a binary tree node.
* public class TreeNode {
*     public int val;
*     public TreeNode left;
*     public TreeNode right;
*     public TreeNode(int x) { val = x; }
* }
*/
using System;
public class DiameterOfBinaryTree
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
    int ans;
    public int DiameterOfBinaryTreee(TreeNode root)
    {
        ans = 1;
        Solve(root);
        return ans - 1;
    }

    private int Solve(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        int left = Solve(root.left);
        int right = Solve(root.right);

        int temp = Math.Max(left, right) + 1;
        ans = Math.Max(ans, left + right + 1);

        return temp;
    }
}