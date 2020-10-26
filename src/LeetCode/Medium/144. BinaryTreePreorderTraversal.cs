/*
https://leetcode.com/problems/binary-tree-preorder-traversal/

Given the root of a binary tree, return the preorder traversal of its nodes' values.

 

Example 1:


Input: root = [1,null,2,3]
Output: [1,2,3]
Example 2:

Input: root = []
Output: []
Example 3:

Input: root = [1]
Output: [1]
Example 4:


Input: root = [1,2]
Output: [1,2]
Example 5:


Input: root = [1,null,2]
Output: [1,2]
 

Constraints:

The number of nodes in the tree is in the range [0, 100].
-100 <= Node.val <= 100
 

Follow up:

Recursive solution is trivial, could you do it iteratively?
*/


using System.Collections.Generic;
/**
* Definition for a binary tree node.
* 
*/
public class BinaryTreePreorderTraversal
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
    IList<int> result = new List<int>();

    //Iterative
    public IList<int> PreorderTraversal_Iterative(TreeNode root)
    {
        if (root == null)
        {
            return result;
        }

        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root);
        while (stack.Count != 0)
        {
            var current = stack.Pop();
            result.Add(current.val);

            if (current.right != null)
            {
                stack.Push(current.right);
            }

            if (current.left != null)
            {
                stack.Push(current.left);
            }
        }

        return result;
    }

    //Recursive
    public IList<int> PreorderTraversal(TreeNode root)
    {
        Solve(root);
        return result;
    }

    private void Solve(TreeNode root)
    {
        if (root == null)
        {
            return;
        }

        result.Add(root.val);
        Solve(root.left);
        Solve(root.right);
    }
}