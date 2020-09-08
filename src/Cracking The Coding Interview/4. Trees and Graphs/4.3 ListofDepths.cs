using System.Collections.Generic;

public class ListofDepths
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

    public IList<IList<int>> NodesatDepth(TreeNode root)
    {
        IList<IList<int>> result = new List<IList<int>>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count != 0)
        {
            int size = queue.Count;
            IList<int> currentRow = new List<int>();
            for (int i = 0; i < size; i++)
            {
                var current = queue.Dequeue();
                if (current.left != null)
                {
                    queue.Enqueue(current.left);
                }

                if (current.right != null)
                {
                    queue.Enqueue(current.right);
                }

                currentRow.Add(current.val);
            }

            result.Add(currentRow);
        }

        return result;
    }
}