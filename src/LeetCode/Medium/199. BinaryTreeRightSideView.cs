/*
https://leetcode.com/problems/binary-tree-right-side-view/

Given a binary tree, imagine yourself standing on the right side of it, return the values of the nodes you can see ordered from top to bottom.

Example:

Input: [1,2,3,null,5,null,4]
Output: [1, 3, 4]
Explanation:

   1            <---
 /   \
2     3         <---
 \     \
  5     4       <---
*/

using System.Collections.Generic;

public class BinaryTreeRightSideView
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
    public IList<int> RightSideView(TreeNode root)
    {
        IList<int> result = new List<int>();
        if (root == null)
        {
            return result;
        }

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count != 0)
        {
            int size = queue.Count;
            result.Add(queue.Peek().val);
            for (int i = 0; i < size; i++)
            {
                var current = queue.Dequeue();
                if (current.right != null)
                {
                    queue.Enqueue(current.right);
                }

                if (current.left != null)
                {
                    queue.Enqueue(current.left);
                }
            }
        }

        return result;
    }
}