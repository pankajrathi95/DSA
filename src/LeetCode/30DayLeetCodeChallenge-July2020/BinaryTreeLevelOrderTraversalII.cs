/*
Given a binary tree, return the bottom-up level order traversal of its nodes' values. (ie, from left to right, level by level from leaf to root).

For example:
Given binary tree [3,9,20,null,null,15,7],
    3
   / \
  9  20
    /  \
   15   7
return its bottom-up level order traversal as:
[
  [15,7],
  [9,20],
  [3]
]
*/

using System;
using System.Collections.Generic;
public class BinaryTreeLevelOrderTraversalII
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
    public IList<IList<int>> LevelOrderBottom(TreeNode root)
    {
        var current = root;
        IList<IList<int>> result = new List<IList<int>>();

        for (int i = 0; i <= Height(root); i++)
        {
            result.Insert(0, GetNodesAtDistance(root, i));
        }

        return result;
    }

    private int Height(TreeNode root)
    {
        if (root == null)
        {
            return -1;
        }

        if (root.left == null && root.right == null)
        {
            return 0;
        }

        return 1 + Math.Max(Height(root.left), Height(root.right));
    }

    private List<int> GetNodesAtDistance(TreeNode root, int length)
    {
        var list = new List<int>();
        GetNodesAtDistance(root, length, list);
        return list;
    }

    private void GetNodesAtDistance(TreeNode root, int length, List<int> list)
    {
        if (root == null)
        {
            return;
        }

        if (length == 0)
        {
            list.Add(root.val);
            return;
        }

        GetNodesAtDistance(root.left, length - 1, list);
        GetNodesAtDistance(root.right, length - 1, list);
    }
}