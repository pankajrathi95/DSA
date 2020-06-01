/*
Invert a binary tree.

Example:

Input:

     4
   /   \
  2     7
 / \   / \
1   3 6   9
Output:

     4
   /   \
  7     2
 / \   / \
9   6 3   1
Trivia:
This problem was inspired by this original tweet by Max Howell:

Google: 90% of our engineers use the software you wrote (Homebrew), but you can’t invert a binary tree on a whiteboard so f*** off.
 */
public class InvertBinaryTree
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
    public TreeNode InvertTree(TreeNode root)
    {
        InvertTrees(root);
        return root;
    }

    private void InvertTrees(TreeNode node)
    {
        if (node == null)
        {
            return;
        }

        var temp = node.left;
        node.left = node.right;
        node.right = temp;

        InvertTrees(node.left);
        InvertTrees(node.right);
    }
}