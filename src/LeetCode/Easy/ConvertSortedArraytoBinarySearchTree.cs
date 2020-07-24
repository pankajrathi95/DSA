/*
https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/
*/

public class ConvertSortedArraytoBinarySearchTree
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
    public TreeNode SortedArrayToBST(int[] nums)
    {
        if (nums == null || nums.Length == 0)
        {
            return null;
        }

        return SortedArrayToBST(nums, 0, nums.Length - 1);
    }

    private TreeNode SortedArrayToBST(int[] nums, int start, int end)
    {
        if (start > end)
        {
            return null;
        }

        int middle = start + (end - start) / 2;
        TreeNode root = new TreeNode(nums[middle]);
        root.left = SortedArrayToBST(nums, start, middle - 1);
        root.right = SortedArrayToBST(nums, middle + 1, end);

        return root;
    }
}