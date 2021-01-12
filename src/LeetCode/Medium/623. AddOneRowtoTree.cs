/*
https://leetcode.com/problems/add-one-row-to-tree/
Given the root of a binary tree, then value v and depth d, you need to add a row of nodes with value v at the given depth d. The root node is at depth 1.

The adding rule is: given a positive integer depth d, for each NOT null tree nodes N in depth d-1, create two tree nodes with value v as N's left subtree root and right subtree root. And N's original left subtree should be the left subtree of the new left subtree root, its original right subtree should be the right subtree of the new right subtree root. If depth d is 1 that means there is no depth d-1 at all, then create a tree node with value v as the new root of the whole original tree, and the original tree is the new root's left subtree.

Example 1:
Input: 
A binary tree as following:
       4
     /   \
    2     6
   / \   / 
  3   1 5   

v = 1

d = 2

Output: 
       4
      / \
     1   1
    /     \
   2       6
  / \     / 
 3   1   5   

Example 2:
Input: 
A binary tree as following:
      4
     /   
    2    
   / \   
  3   1    

v = 1

d = 3

Output: 
      4
     /   
    2
   / \    
  1   1
 /     \  
3       1
Note:
The given d is in range [1, maximum depth of the given tree + 1].
The given binary tree has at least one tree node.
*/

using System.Collections.Generic;

public class AddOneRowtoTree
{
    public TreeNode AddOneRow(TreeNode root, int v, int d)
    {
        if (d == 1)
        {
            TreeNode newRoot = new TreeNode(v);
            newRoot.left = root;
            return newRoot;
        }

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count != 0 && d > 2)
        {
            int size = queue.Count;
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

            d--;
        }

        while (queue.Count != 0)
        {
            var current = queue.Dequeue();
            var leftNode = current.left;
            var rightNode = current.right;

            current.left = new TreeNode(v);
            current.right = new TreeNode(v);

            current.left.left = leftNode;
            current.right.right = rightNode;
        }

        return root;
    }
}