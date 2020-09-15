public class PathWithSum
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
    int count = 0;
    public int PathSum(TreeNode root, int sum)
    {
        if (root == null)
        {
            return 0;
        }

        FindPathSum(root, sum, root.val);
        PathSum(root.left, sum);
        PathSum(root.right, sum);

        return count;
    }

    private void FindPathSum(TreeNode root, int totalSum, int currentSum)
    {
        if (root == null)
        {
            return;
        }


        if (currentSum == totalSum)
        {
            count += 1;
        }

        if (root.left != null)
        {
            FindPathSum(root.left, totalSum, currentSum + root.left.val);
        }

        if (root.right != null)
        {
            FindPathSum(root.right, totalSum, currentSum + root.right.val);
        }
    }
}