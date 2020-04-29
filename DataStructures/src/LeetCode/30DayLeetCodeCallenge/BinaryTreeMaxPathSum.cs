/**
* Definition for a binary tree node.

Given a non-empty binary tree, find the maximum path sum.

For this problem, a path is defined as any sequence of nodes from some starting node to any node in the tree along the parent-child connections. 
The path must contain at least one node and does not need to go through the root.

Example 1:

Input: [1,2,3]

       1
      / \
     2   3

Output: 6
Example 2:

Input: [-10,9,20,null,null,15,7]

   -10
   / \
  9  20
    /  \
   15   7

Output: 42
*/
using System;

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
public class BinaryTreeMaxPathSum
{
    int max;
    public int MaxPathSum(TreeNode root)
    {
        max = Int32.MinValue;
        SumOfNodes(root);
        return max;

    }

    public int SumOfNodes(TreeNode node)
    {
        if (node == null)
        {
            return 0;
        }

        int left = SumOfNodes(node.left);
        int right = SumOfNodes(node.right);

        int sum = node.val + Math.Max(left, 0) + Math.Max(right, 0);
        max = Math.Max(sum, max);
        sum = node.val + Math.Max(0, Math.Max(left, right));
        return sum;
    }
}