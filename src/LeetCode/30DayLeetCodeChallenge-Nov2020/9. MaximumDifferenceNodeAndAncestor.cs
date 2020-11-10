/*


*/


using System;
/**
* Definition for a binary tree node.
* 
*/
public class MaximumDifferenceNodeAndAncestor
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

    //My Appraoch (Not optimized)
    int max = 0;
    public int MaxAncestorDiff(TreeNode root)
    {
        if (root != null)
        {
            Solve(root.left, root);
            Solve(root.right, root);

            return Math.Max(MaxAncestorDiff(root.left), MaxAncestorDiff(root.right));
        }

        return max;
    }

    private void Solve(TreeNode root, TreeNode parent)
    {
        if (root == null || parent == null)
        {
            return;
        }

        max = Math.Max(max, Math.Abs(root.val - parent.val));

        Solve(root.left, parent);
        Solve(root.right, parent);
    }

    //Optimized Appraoch

    int res = 0;
    public int MaxAncestorDifff(TreeNode root)
    {
        Solve(root, root.val, root.val);
        return res;
    }

    private void Solve(TreeNode root, int min, int max)
    {
        if (root == null)
        {
            return;
        }

        min = Math.Min(min, root.val);
        max = Math.Max(max, root.val);

        res = Math.Max(res, max - min);

        Solve(root.left, min, max);
        Solve(root.right, min, max);
    }
}