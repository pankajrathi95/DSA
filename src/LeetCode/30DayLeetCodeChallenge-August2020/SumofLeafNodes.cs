/*

*/

public class SumofLeafNodes
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
    int sum = 0;
    public int SumOfLeftLeaves(TreeNode root)
    {

        Sum(root);
        return sum;
    }

    private void Sum(TreeNode root)
    {
        if (root == null || root.left == null)
        {
            return;
        }

        if (root.left != null && root.left.left == null && root.left.right == null)
        {
            sum += root.left.val;
        }

        Sum(root.left);
        Sum(root.right);
    }
}