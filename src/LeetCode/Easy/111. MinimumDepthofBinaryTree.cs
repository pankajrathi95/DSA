/*
Given a binary tree, find its minimum depth.

The minimum depth is the number of nodes along the shortest path from the root node down to the nearest leaf node.

Note: A leaf is a node with no children.

 

Example 1:


Input: root = [3,9,20,null,null,15,7]
Output: 2
Example 2:

Input: root = [2,null,3,null,4,null,5,null,6]
Output: 5
 

Constraints:

The number of nodes in the tree is in the range [0, 104].
-1000 <= Node.val <= 1000
*/

using System;

public class MinimumDepthofBinaryTree
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

    public int MinDepth(TreeNode root)
    {
        return Depth(root);
    }

    private int Depth(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        int left = Depth(root.left);
        int right = Depth(root.right);

        if (left == 0)
        {
            return right + 1;
        }
        if (right == 0)
        {
            return left + 1;
        }
        return Math.Min(left, right) + 1;
    }
}