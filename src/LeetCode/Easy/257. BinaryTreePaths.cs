/*
https://leetcode.com/problems/binary-tree-paths/

Given a binary tree, return all root-to-leaf paths.

Note: A leaf is a node with no children.

Example:

Input:

   1
 /   \
2     3
 \
  5

Output: ["1->2->5", "1->3"]

Explanation: All root-to-leaf paths are: 1->2->5, 1->3
*/

using System.Collections.Generic;

public class BinaryTreePaths
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
    IList<string> result = new List<string>();
    public IList<string> FindBinaryTreePaths(TreeNode root)
    {
        if (root == null)
        {
            return result;
        }

        Solve(root, "");
        return result;
    }

    private void Solve(TreeNode root, string sb)
    {
        if (root == null)
        {
            return;
        }

        if (root.left == null && root.right == null)
        {
            result.Add(sb + root.val);
            return;
        }

        Solve(root.left, sb + root.val + "->");
        Solve(root.right, sb + root.val + "->");
    }
}