public class MinimalTree
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

    public TreeNode FindMinimalTree(int[] arr)
    {
        return CreateMinimalTree(arr, 0, arr.Length - 1);
    }

    private TreeNode CreateMinimalTree(int[] arr, int start, int end)
    {
        if (start > end)
        {
            return null;
        }

        int mid = (start + end) / 2;
        TreeNode root = new TreeNode(arr[mid]);
        root.left = CreateMinimalTree(arr, start, mid - 1);
        root.right = CreateMinimalTree(arr, mid + 1, end);

        return root;
    }
}