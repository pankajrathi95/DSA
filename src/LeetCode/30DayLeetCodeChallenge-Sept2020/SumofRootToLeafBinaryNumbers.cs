/*
Given a binary tree, each node has value 0 or 1.  Each root-to-leaf path represents a binary number starting with the most significant bit.  For example, if the path is 0 -> 1 -> 1 -> 0 -> 1, then this could represent 01101 in binary, which is 13.

For all leaves in the tree, consider the numbers represented by the path from the root to that leaf.

Return the sum of these numbers.

 

Example 1:



Input: [1,0,1,0,1,0,1]
Output: 22
Explanation: (100) + (101) + (110) + (111) = 4 + 5 + 6 + 7 = 22
 

Note:

The number of nodes in the tree is between 1 and 1000.
node.val is 0 or 1.
The answer will not exceed 2^31 - 1.
   Hide Hint #1  
Find each path, then transform that path to an integer in base 10.
*/

using System;

public class SumofRootToLeafBinaryNumbers
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

    int sum = 0;
    public int SumRootToLeaf(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        Traverse(root, "");
        return sum;
    }

    private void Traverse(TreeNode root, string str)
    {
        if (root == null)
        {
            return;
        }

        str += "" + root.val;

        if (root.left == null && root.right == null)
        {
            sum += Convert.ToInt32(str, 2);
        }

        Traverse(root.left, str);
        Traverse(root.right, str);
    }
}