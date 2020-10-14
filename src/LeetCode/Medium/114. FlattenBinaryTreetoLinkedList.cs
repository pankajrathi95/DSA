/*
https://leetcode.com/problems/flatten-binary-tree-to-linked-list/
Given a binary tree, flatten it to a linked list in-place.

For example, given the following tree:

    1
   / \
  2   5
 / \   \
3   4   6
The flattened tree should look like:

1
 \
  2
   \
    3
     \
      4
       \
        5
         \
          6
*/

public class FlattenBinaryTreetoLinkedList
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

    public void Flatten(TreeNode root)
    {
        Solve(root);
    }

    private void Solve(TreeNode root)
    {
        if (root == null)
        {
            return;
        }

        Solve(root.left);
        Solve(root.right);

        var temp = root.right;
        root.right = root.left;
        root.left = null;
        while (root.right != null)
        {
            root = root.right;
        }

        root.right = temp;
    }
}