/*
In a binary tree, the root node is at depth 0, and children of each depth k node are at depth k+1.

Two nodes of a binary tree are cousins if they have the same depth, but have different parents.

We are given the root of a binary tree with unique values, and the values x and y of two different nodes in the tree.

Return true if and only if the nodes corresponding to the values x and y are cousins.

 

Example 1:


Input: root = [1,2,3,4], x = 4, y = 3
Output: false
Example 2:


Input: root = [1,2,3,null,4,null,5], x = 5, y = 4
Output: true
Example 3:



Input: root = [1,2,3,null,4], x = 2, y = 3
Output: false
 

Note:

The number of nodes in the tree will be between 2 and 100.
Each node has a unique integer value from 1 to 100.

*/

public class CousinsInBinaryTree
{
    int depth_x = 0;
    int depth_y = 0;
    bool isSameParent = false;

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
    public bool IsCousins(TreeNode root, int x, int y)
    {
        if (root.val == x || root.val == y)
        {
            return false;
        }

        FindCousins(root, x, y, 0);

        if (!isSameParent && depth_x == depth_y)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    private void FindCousins(TreeNode node, int x, int y, int depth)
    {
        if (node == null)
        {
            return;
        }

        if (node.left != null && node.right != null &&
            (node.left.val == x || node.left.val == y) &&
            (node.right.val == x || node.right.val == y))
        {
            isSameParent = true;
            return;
        }

        if (node.val == x)
        {
            depth_x = depth;
            return;
        }

        if (node.val == y)
        {
            depth_y = depth;
            return;
        }

        FindCousins(node.left, x, y, depth + 1);
        FindCousins(node.right, x, y, depth + 1);
    }
}