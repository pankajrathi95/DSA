/*
https://leetcode.com/problems/merge-two-binary-trees/
*/

/**
 * Definition for a binary tree node.
 * 
 */
public class MergeTwoBinaryTrees
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
    public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
    {
        if (t1 == null || t2 == null)
        {
            return t1 == null ? t2 : t1;
        }

        MergeTree_Rec(t1, t2);
        return t1;
    }

    private void MergeTree_Rec(TreeNode t1, TreeNode t2)
    {
        if (t1 != null && t2 != null)
        {
            MergeTree_Rec(t1.left, t2.left);
            MergeTree_Rec(t1.right, t2.right);

            t1.val += t2.val;
            if (t1.left == null && t2.left != null)
            {
                t1.left = t2.left;
            }

            if (t1.right == null && t2.right != null)
            {
                t1.right = t2.right;
            }
        }
    }
}