/*
Given a binary tree, write a function to get the maximum width of the given tree. The width of a tree is the maximum width among all levels. The binary tree has the same structure as a full binary tree, but some nodes are null.

The width of one level is defined as the length between the end-nodes (the leftmost and right most non-null nodes in the level, where the null nodes between the end-nodes are also counted into the length calculation.

Example 1:

Input: 

           1
         /   \
        3     2
       / \     \  
      5   3     9 

Output: 4
Explanation: The maximum width existing in the third level with the length 4 (5,3,null,9).
Example 2:

Input: 

          1
         /  
        3    
       / \       
      5   3     

Output: 2
Explanation: The maximum width existing in the third level with the length 2 (5,3).
Example 3:

Input: 

          1
         / \
        3   2 
       /        
      5      

Output: 2
Explanation: The maximum width existing in the second level with the length 2 (3,2).
Example 4:

Input: 

          1
         / \
        3   2
       /     \  
      5       9 
     /         \
    6           7
Output: 8
Explanation:The maximum width existing in the fourth level with the length 8 (6,null,null,null,null,null,null,7).


Note: Answer will in the range of 32-bit signed integer.
*/


using System;
using System.Collections.Generic;
using System.Linq;

public class MaximumWidthofBinaryTree
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

    public int WidthOfBinaryTree(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        int result = 1;
        Queue<KeyValuePair<TreeNode, int>> queue = new Queue<KeyValuePair<TreeNode, int>>();
        queue.Enqueue(new KeyValuePair<TreeNode, int>(root, 0));

        while (queue.Count != 0)
        {
            int count = queue.Count;
            int start = queue.Peek().Value;
            int end = queue.Last().Value;

            result = Math.Max(result, end - start + 1);
            for (int i = 0; i < count; i++)
            {
                KeyValuePair<TreeNode, int> kvp = queue.Peek();
                int idx = kvp.Value - start;
                queue.Dequeue();
                if (kvp.Key.left != null)
                {
                    queue.Enqueue(new KeyValuePair<TreeNode, int>(kvp.Key.left, 2 * idx + 1));
                }

                if (kvp.Key.right != null)
                {
                    queue.Enqueue(new KeyValuePair<TreeNode, int>(kvp.Key.right, 2 * idx + 2));
                }
            }
        }

        return result;
    }
}