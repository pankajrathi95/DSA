/*
https://leetcode.com/problems/path-sum/
Given a binary tree and a sum, determine if the tree has a root-to-leaf path such that adding up all the values along the path equals the given sum.

Note: A leaf is a node with no children.

Example:

Given the below binary tree and sum = 22,

      5
     / \
    4   8
   /   / \
  11  13  4
 /  \      \
7    2      1
return true, as there exist a root-to-leaf path 5->4->11->2 which sum is 22.
*/

public class PathSum
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

    bool flag = false;
    public bool HasPathSum(TreeNode root, int sum)
    {
        if (root == null)
        {
            return false;
        }

        return FindPathSum(root, sum, root.val);
    }

    private bool FindPathSum(TreeNode root, int totalSum, int currentSum)
    {
        if (root == null)
        {
            return flag;
        }


        if (currentSum == totalSum && root.left == null && root.right == null)
        {
            return flag = true;
        }

        if (root.left != null)
        {
            FindPathSum(root.left, totalSum, currentSum + root.left.val);
        }

        if (root.right != null)
        {
            FindPathSum(root.right, totalSum, currentSum + root.right.val);
        }

        return flag;
    }
}
