/*
https://leetcode.com/problems/find-bottom-left-tree-value/
Given the root of a binary tree, return the leftmost value in the last row of the tree. 

Example 1:


Input: root = [2,1,3]
Output: 1
Example 2:


Input: root = [1,2,3,4,null,5,6,null,null,7]
Output: 7
 

Constraints:

The number of nodes in the tree is in the range [1, 104].
-231 <= Node.val <= 231 - 1
*/

using System.Collections.Generic;

public class FindBottomLeftTreeValue
{
    public int FindBottomLeftValue(TreeNode root)
    {
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int result = 0;
        //Do a BFS traversal on the tree using queue
        while (queue.Count != 0)
        {
            int size = queue.Count;
            result = queue.Peek().val;  // at each iteration, store the first value of the queue. This will be your left most value for the tree     
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
            }
        }

        return result;
    }
}