/*
https://leetcode.com/problems/path-sum-ii/
Given a binary tree and a sum, find all root-to-leaf paths where each path's sum equals the given sum.

Note: A leaf is a node with no children.

Example:

Given the below binary tree and sum = 22,

      5
     / \
    4   8
   /   / \
  11  13  4
 /  \    / \
7    2  5   1
Return:

[
   [5,4,11,2],
   [5,8,4,5]
]
*/


using System.Collections.Generic;

public class PathSumII
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

    IList<IList<int>> result = new List<IList<int>>();
    public IList<IList<int>> PathSum(TreeNode root, int sum)
    {

        if (root == null)
        {
            return result;
        }

        FindPathSum(root, sum, root.val, new List<int>());

        return result;
    }


    private void FindPathSum(TreeNode root, int totalSum, int currentSum, IList<int> currentNodes)
    {
        if (root == null)
        {
            return;
        }

        currentNodes.Add(root.val);

        if (currentSum == totalSum && root.left == null && root.right == null)
        {
            var temp = new List<int>();
            temp.AddRange(currentNodes);
            result.Add(temp);
        }

        if (root.left != null)
        {
            FindPathSum(root.left, totalSum, currentSum + root.left.val, currentNodes);
        }



        if (root.right != null)
        {
            FindPathSum(root.right, totalSum, currentSum + root.right.val, currentNodes);
        }

        currentNodes.RemoveAt(currentNodes.Count - 1);
    }
}
