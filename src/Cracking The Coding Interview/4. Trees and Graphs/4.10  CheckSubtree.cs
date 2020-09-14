public class CheckSubtree
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

    public bool IsSubtree(TreeNode s, TreeNode t)
    {
        if (s == null && t == null)
        {
            return true;
        }

        if (s == null || t == null)
        {
            return false;
        }

        return IsIdentical(s, t) || IsSubtree(s.left, t) || IsSubtree(s.right, t);
    }


    private bool IsIdentical(TreeNode s, TreeNode t)
    {
        if (s == null && t == null)
        {
            return true;
        }

        if (s == null || t == null)
        {
            return false;
        }

        return s.val == t.val && IsIdentical(s.left, t.left) && IsIdentical(s.right, t.right);
    }
}