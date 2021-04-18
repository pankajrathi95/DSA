/*
https://leetcode.com/problems/delete-nodes-and-return-forest/

Given the root of a binary tree, each node in the tree has a distinct value.

After deleting all nodes with a value in to_delete, we are left with a forest (a disjoint union of trees).

Return the roots of the trees in the remaining forest. You may return the result in any order.

 

Example 1:


Input: root = [1,2,3,4,5,6,7], to_delete = [3,5]
Output: [[1,2,null,4],[6],[7]]
Example 2:

Input: root = [1,2,4,null,3], to_delete = [3]
Output: [[1,2,4]]
 

Constraints:

The number of nodes in the given tree is at most 1000.
Each node has a distinct value between 1 and 1000.
to_delete.length <= 1000
to_delete contains distinct values between 1 and 1000.
*/


using System.Collections.Generic;
public class DeleteNodesAndReturnForest
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

    //Initial approach which I did and got accepted.
    public IList<TreeNode> DelNodes(TreeNode root, int[] to_delete)
    {
        IList<TreeNode> result = new List<TreeNode>();
        if (root == null)
        {
            return result;
        }

        HashSet<int> deleted = new HashSet<int>(to_delete);
        if (!deleted.Contains(root.val))
            result.Add(root);
        NodesToDelete(root, deleted, result, null, root);
        return result;
    }

    private void NodesToDelete(TreeNode root, HashSet<int> deleted, IList<TreeNode> result, TreeNode parent, TreeNode main)
    {
        if (root == null)
        {
            return;
        }

        if (deleted.Contains(root.val))
        {
            if (root.left != null && !deleted.Contains(root.left.val))
            {
                result.Add(root.left);
            }

            if (root.right != null && !deleted.Contains(root.right.val))
            {
                result.Add(root.right);
            }

            if (parent != null)
            {
                if (parent.left == root)
                    parent.left = null;
                else
                    parent.right = null;
            }
        }

        NodesToDelete(root.left, deleted, result, root, main);
        NodesToDelete(root.right, deleted, result, root, main);
    }

    //Saw this approach and it looks clean.
    public IList<TreeNode> DelNodes_(TreeNode root, int[] to_delete)
    {
        IList<TreeNode> result = new List<TreeNode>();
        if (root == null)
        {
            return result;
        }

        HashSet<int> deleted = new HashSet<int>(to_delete);
        if (!deleted.Contains(root.val))
            result.Add(root);
        NodesToDelete(root, deleted, result);
        return result;
    }

    private TreeNode NodesToDelete(TreeNode root, HashSet<int> deleted, IList<TreeNode> result)
    {
        if (root == null)
        {
            return null;
        }

        root.left = NodesToDelete(root.left, deleted, result);
        root.right = NodesToDelete(root.right, deleted, result);

        if (deleted.Contains(root.val))
        {
            if (root.left != null)
            {
                result.Add(root.left);
            }

            if (root.right != null)
            {
                result.Add(root.right);
            }

            return null;
        }

        return root;
    }
}