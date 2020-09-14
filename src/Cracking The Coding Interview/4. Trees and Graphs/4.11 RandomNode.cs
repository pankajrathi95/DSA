using System;

public class RandomNode
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public int size;
        public TreeNode(int val = 0, int size = 1, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
            this.size = size;
        }

        public TreeNode GetRandomNode()
        {
            int leftSize = left == null ? 0 : left.size;
            Random random = new Random();
            int index = random.Next(size);
            if (index < leftSize)
            {
                return left.GetRandomNode();
            }
            else if (index == leftSize)
            {
                return this;
            }
            else
            {
                return right.GetRandomNode();
            }
        }
    }
}