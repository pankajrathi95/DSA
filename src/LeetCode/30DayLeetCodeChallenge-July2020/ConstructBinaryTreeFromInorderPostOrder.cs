/*
Given inorder and postorder traversal of a tree, construct the binary tree.

Note:
You may assume that duplicates do not exist in the tree.

For example, given

inorder = [9,3,15,20,7]
postorder = [9,15,7,20,3]
Return the following binary tree:

    3
   / \
  9  20
    /  \
   15   7
*/

public class ConstructBinaryTreeFromInorderPostOrder
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
    public TreeNode BuildTree(int[] inorder, int[] postorder)
    {
        int n = inorder.Length;
        if (n == 0)
        {
            return null;
        }

        return BuildTree(inorder, postorder, 0, n, 0, n);
    }

    private TreeNode BuildTree(int[] inorder, int[] postorder, int i1, int i2, int p1, int p2)
    {
        if (i1 >= i2 || p1 >= p2)
        {
            return null;
        }
        TreeNode root = new TreeNode(postorder[p2 - 1]);

        int it = 0;
        for (int i = i1; i < i2; i++)
        {
            if (postorder[p2 - 1] == inorder[i])
            {
                it = i;
                break;
            }
        }

        int diff = it - i1;
        root.left = BuildTree(inorder, postorder, i1, i1 + diff, p1, p1 + diff);
        root.right = BuildTree(inorder, postorder, i1 + diff + 1, i2, p1 + diff, p2 - 1);

        return root;
    }
}