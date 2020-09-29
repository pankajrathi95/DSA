/*
#1008 - https://leetcode.com/problems/construct-binary-search-tree-from-preorder-traversal/
Return the root node of a binary search tree that matches the given preorder traversal.

(Recall that a binary search tree is a binary tree where for every node, any descendant of node.left has a value < node.val, and any descendant of node.right has a value > node.val.  Also recall that a preorder traversal displays the value of the node first, then traverses node.left, then traverses node.right.)

 

Example 1:

Input: [8,5,1,7,10,12]
Output: [8,5,10,1,7,null,12]

 

Note: 

1 <= preorder.length <= 100
The values of preorder are distinct.

*/

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class BinaryTreePreOrderTraversal
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    //Recursive Appraoch
    public TreeNode BstFromPreorder(int[] preorder)
    {
        TreeNode root = null;
        foreach (var item in preorder)
        {
            root = Dfs(root, item);
        }

        return root;
    }

    private TreeNode Dfs(TreeNode root, int ele)
    {
        if (root == null)
        {
            return root = new TreeNode(ele);
        }

        if (root.val > ele)
        {
            root.left = Dfs(root.left, ele);
        }
        else
        {
            root.right = Dfs(root.right, ele);
        }

        return root;
    }

    //Iterative Approach
    TreeNode root = null;
    public TreeNode BstFromPreorderr(int[] preorder)
    {
        if (preorder.Length == 0 || preorder == null)
        {
            return null;
        }
        root = new TreeNode(preorder[0]);
        for (int i = 1; i < preorder.Length; i++)
        {
            AddNode(preorder[i]);
        }

        return root;
    }

    private void AddNode(int value)
    {
        var current = root;
        while (true)
        {
            if (value > current.val)
            {
                if (current.right == null)
                {
                    current.right = new TreeNode(value);
                    break;
                }

                current = current.right;
            }
            else
            {
                if (current.left == null)
                {
                    current.left = new TreeNode(value);
                    break;
                }

                current = current.left;
            }
        }
    }

}