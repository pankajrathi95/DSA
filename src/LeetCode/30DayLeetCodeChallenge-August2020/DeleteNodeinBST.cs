/*
Given a root node reference of a BST and a key, delete the node with the given key in the BST. Return the root node reference (possibly updated) of the BST.

Basically, the deletion can be divided into two stages:

Search for a node to remove.
If the node is found, delete the node.
Note: Time complexity should be O(height of tree).

Example:

root = [5,3,6,2,4,null,7]
key = 3

    5
   / \
  3   6
 / \   \
2   4   7

Given key to delete is 3. So we find the node with value 3 and delete it.

One valid answer is [5,4,6,2,null,null,7], shown in the following BST.

    5
   / \
  4   6
 /     \
2       7

Another valid answer is [5,2,6,null,4,null,7].

    5
   / \
  2   6
   \   \
    4   7
*/

public class DeleteNodeinBST
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
    public TreeNode DeleteNode(TreeNode root, int key)
    {
        if (root == null)
        {
            return root;
        }
        else if (root.val > key)
        {
            root.left = DeleteNode(root.left, key);
        }
        else if (root.val < key)
        {
            root.right = DeleteNode(root.right, key);
        }
        else
        {
            if (root.left == null && root.right == null)
            {
                return null;
            }
            else if (root.left == null)
            {
                return root.right;
            }
            else if (root.right == null)
            {
                return root.left;
            }
            else
            {
                int min = GetMinValue(root.right, int.MaxValue);
                root.val = min;
                root.right = DeleteNode(root.right, min);
            }
        }

        return root;
    }

    private int GetMinValue(TreeNode root, int min)
    {
        if (root == null)
        {
            return min;
        }

        min = root.val;
        return GetMinValue(root.left, min);
    }
}