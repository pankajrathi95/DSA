/*
#107 - https://leetcode.com/problems/binary-tree-level-order-traversal-ii/
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
using System.Linq;

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
        if (root == null) return new List<IList<int>>();
        List<List<int>> result = new List<List<int>>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count != 0)
        {
            int size = queue.Count;
            List<int> temp = new List<int>();
            for (int i = 0; i < size; i++)
            {
                var current = queue.Dequeue();
                temp.Add(current.val);
                if (current.left != null)
                {
                    queue.Enqueue(current.left);
                }

                if (current.right != null)
                {
                    queue.Enqueue(current.right);
                }
            }

            result.Add(temp);
        }

        result.Reverse();
        return ((IList<IList<int>>)result.Cast<IList<int>>().ToList());
    }
}