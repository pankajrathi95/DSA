/*
Given a binary tree containing digits from 0-9 only, each root-to-leaf path could represent a number.

An example is the root-to-leaf path 1->2->3 which represents the number 123.

Find the total sum of all root-to-leaf numbers.

Note: A leaf is a node with no children.

Example:

Input: [1,2,3]
    1
   / \
  2   3
Output: 25
Explanation:
The root-to-leaf path 1->2 represents the number 12.
The root-to-leaf path 1->3 represents the number 13.
Therefore, sum = 12 + 13 = 25.
Example 2:

Input: [4,9,0,5,1]
    4
   / \
  9   0
 / \
5   1
Output: 1026
Explanation:
The root-to-leaf path 4->9->5 represents the number 495.
The root-to-leaf path 4->9->1 represents the number 491.
The root-to-leaf path 4->0 represents the number 40.
Therefore, sum = 495 + 491 + 40 = 1026.
*/
using System.Collections.Generic;

public class SumRootToLeafNumbers
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
    public int SumNumbers(TreeNode root)
    {
        List<string> values = new List<string>();
        if (root == null)
        {
            return 0;
        }

        SumNumbers(root, root.val.ToString(), values);

        int sum = 0;
        foreach (var vals in values)
        {
            sum += int.Parse(vals);
        }

        return sum;
    }

    private void SumNumbers(TreeNode root, string value, List<string> values)
    {
        if (root == null)
        {
            return;
        }

        if (root.left == null && root.right == null)
        {
            values.Add(value);
            return;
        }

        SumNumbers(root.left, value + (root.left == null ? "" : root.left.val.ToString()), values);
        SumNumbers(root.right, value + (root.right == null ? "" : root.right.val.ToString()), values);
    }
}