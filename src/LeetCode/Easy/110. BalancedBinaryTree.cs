/*
https://leetcode.com/problems/balanced-binary-tree/

Given a binary tree, determine if it is height-balanced.

For this problem, a height-balanced binary tree is defined as:

a binary tree in which the left and right subtrees of every node differ in height by no more than 1.

 

Example 1:


Input: root = [3,9,20,null,null,15,7]
Output: true
Example 2:


Input: root = [1,2,2,3,3,null,null,4,4]
Output: false
Example 3:

Input: root = []
Output: true
 

Constraints:

The number of nodes in the tree is in the range [0, 5000].
-104 <= Node.val <= 104
*/

/*
We need to drill down to the last node that is a depth first search adn at each node see what is the height of the node.
If the height of left and right nodes is greater than 1 that means it is unbalanced and we will assign the height as -1.
We bubble up the same value to the top of the recursion and return -1. and if the resultant is -1 that means the tree is unbalanced
*/
using System;

public class BalancedBinaryTree
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

    bool res = true;
    public bool IsBalanced(TreeNode root)
    {
        if (root == null)
        {
            return true;
        }

        Solve(root);
        return res;
    }

    private int Solve(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        int left = Solve(root.left);
        int right = Solve(root.right);

        if (Math.Abs(left - right) > 1)
        {
            res = false;
        }

        return Math.Max(left, right) + 1;

    }
}