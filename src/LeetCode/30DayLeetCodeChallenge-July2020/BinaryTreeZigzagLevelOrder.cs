/*
Given a binary tree, return the zigzag level order traversal of its nodes' values. (ie, from left to right, then right to left for the next level and alternate between).

For example:
Given binary tree [3,9,20,null,null,15,7],
    3
   / \
  9  20
    /  \
   15   7
return its zigzag level order traversal as:
[
  [3],
  [20,9],
  [15,7]
]
*/

using System;
using System.Collections.Generic;
using System.Linq;

public class BinaryTreeZigzagLevelOrder
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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
    {
        IList<IList<int>> result = new List<IList<int>>();
        if (root == null)
        {
            return result;
        }

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        bool leftToRight = true;
        while (queue.Count != 0)
        {
            int size = queue.Count;
            LinkedList<int> list = new LinkedList<int>();
            for (int i = 0; i < size; i++)
            {
                var current = queue.Dequeue();
                if (leftToRight)
                {
                    list.AddLast(current.val);
                }
                else
                {
                    list.AddFirst(current.val);
                }

                if (current.left != null)
                {
                    queue.Enqueue(current.left);
                }

                if (current.right != null)
                {
                    queue.Enqueue(current.right);
                }
            }

            result.Add(new List<int>(list));
            leftToRight = !leftToRight;
        }

        return result;
    }
}