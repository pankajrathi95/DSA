public class BstFromPreOrder
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
    TreeNode root;

    public TreeNode BstFromPreorder(int[] preorder)
    {
        if (preorder.Length == 0 || preorder == null)
        {
            return null;
        }
        root = new TreeNode(preorder[0]);
        for (int i = 1; i < preorder.Length; i++)
        {
            AddNode(preorder[i]);
        }

        return root;
    }

    private void AddNode(int value)
    {
        var current = root;
        while (true)
        {
            if (value > current.val)
            {
                if (current.right == null)
                {
                    current.right = new TreeNode(value);
                    break;
                }

                current = current.right;
            }
            else
            {
                if (current.left == null)
                {
                    current.left = new TreeNode(value);
                    break;
                }

                current = current.left;
            }
        }
    }
}