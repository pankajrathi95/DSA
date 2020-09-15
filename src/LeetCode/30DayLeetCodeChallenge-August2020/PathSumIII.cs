/*
You are given a binary tree in which each node contains an integer value.

Find the number of paths that sum to a given value.

The path does not need to start or end at the root or a leaf, but it must go downwards (traveling only from parent nodes to child nodes).

The tree has no more than 1,000 nodes and the values are in the range -1,000,000 to 1,000,000.

Example:

root = [10,5,-3,3,2,null,11,3,-2,null,1], sum = 8

      10
     /  \
    5   -3
   / \    \
  3   2   11
 / \   \
3  -2   1

Return 3. The paths that sum to 8 are:

1.  5 -> 3
2.  5 -> 2 -> 1
3. -3 -> 11
*/


public class PathSumIII
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
