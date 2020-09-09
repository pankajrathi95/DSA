public class FirstCommonAncestor
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

    public TreeNode FindFirstCommonAncestor(TreeNode root, TreeNode n1, TreeNode n2)
    {
        if (root == null)
        {
            return null;
        }

        if (root == n1 || root == n2)
        {
            return root;
        }

        TreeNode left = FindFirstCommonAncestor(root.left, n1, n2);
        TreeNode right = FindFirstCommonAncestor(root.right, n1, n2);
        if (left != null && right != null)
        {
            return root;
        }

        if (left == null && right == null)
        {
            return null;
        }

        return left != null ? left : right;
    }
}