/*
#1302 - https://leetcode.com/problems/deepest-leaves-sum/

Given the root of a binary tree, return the sum of values of its deepest leaves.
 

Example 1:


Input: root = [1,2,3,4,5,null,6,7,null,null,null,null,8]
Output: 15
Example 2:

Input: root = [6,7,8,2,7,1,3,9,null,1,4,null,null,null,5]
Output: 19
 

Constraints:

The number of nodes in the tree is in the range [1, 104].
1 <= Node.val <= 100
   Hide Hint #1  
Traverse the tree to find the max depth.
   Hide Hint #2  
Traverse the tree again to compute the sum required.
*/


using System;

public class DeepestLeavesSum
{
    public int FindDeepestLeavesSum(TreeNode root)
    {
        int depth = MaxDepth(root);
        return SumOfLeaves(root, depth);
    }

    private int MaxDepth(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
    }

    private int SumOfLeaves(TreeNode root, int level)
    {
        if (root == null)
        {
            return 0;
        }

        if (level == 1)
        {
            return root.val;
        }

        return SumOfLeaves(root.left, level - 1) + SumOfLeaves(root.right, level - 1);
    }
}