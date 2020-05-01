/*Return the root node of a binary search tree that matches the given preorder traversal.

(Recall that a binary search tree is a binary tree where for every node, any descendant of node.left has a value < node.val, and any descendant of node.right has a value > node.val.  Also recall that a preorder traversal displays the value of the node first, then traverses node.left, then traverses node.right.)

 

Example 1:

Input: [8,5,1,7,10,12]
Output: [8,5,10,1,7,null,12]

 

Note: 

1 <= preorder.length <= 100
The values of preorder are distinct.

*/

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class BinaryTreePreOrderTraversal
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
    public class Index
    {
        public int index = 0;
    }

    public TreeNode BstFromPreorder(int[] preorder, Index index, int key, int min, int max, int size)
    {
        if (index.index >= size)
        {
            return null;
        }
        TreeNode root = null;
        if (key > min && key < max)
        {
            root = new TreeNode(key);
            index.index++;
            if (index.index < size)
            {
                root.left = BstFromPreorder(preorder, index, preorder[index.index], min, key, size);
            }
            if (index.index < size)
            {
                root.right = BstFromPreorder(preorder, index, preorder[index.index], key, max, size);
            }
        }
        return root;

    }
    public TreeNode BstFromPreorder(int[] preorder)
    {
        if (preorder.Length == 0)
            return null;
        Index index = new Index();
        return BstFromPreorder(preorder, index, preorder[0], int.MinValue, int.MaxValue, preorder.Length);

    }
}