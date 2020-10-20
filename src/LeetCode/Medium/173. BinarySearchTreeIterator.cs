/*
https://leetcode.com/problems/binary-search-tree-iterator/
Implement an iterator over a binary search tree (BST). Your iterator will be initialized with the root node of a BST.

Calling next() will return the next smallest number in the BST.

 

Example:



BSTIterator iterator = new BSTIterator(root);
iterator.next();    // return 3
iterator.next();    // return 7
iterator.hasNext(); // return true
iterator.next();    // return 9
iterator.hasNext(); // return true
iterator.next();    // return 15
iterator.hasNext(); // return true
iterator.next();    // return 20
iterator.hasNext(); // return false
 

Note:

next() and hasNext() should run in average O(1) time and uses O(h) memory, where h is the height of the tree.
You may assume that next() call will always be valid, that is, there will be at least a next smallest number in the BST when next() is called.
*/


using System.Collections.Generic;

public class BinarySearchTreeIterator
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
    TreeNode root;
    List<int> visited;
    public BinarySearchTreeIterator(TreeNode root)
    {
        this.root = root;
        visited = new List<int>();
        AddNode(root);
    }

    private void AddNode(TreeNode root)
    {
        if (root == null)
        {
            return;
        }

        AddNode(root.left);
        visited.Add(root.val);
        AddNode(root.right);
    }

    /** @return the next smallest number */
    public int Next()
    {
        if (visited.Count == 0)
        {
            return -1;
        }

        int x = visited[0];
        visited.Remove(x);
        return x;
    }

    /** @return whether we have a next smallest number */
    public bool HasNext()
    {
        return visited.Count != 0;
    }
}

/**
 * Your BSTIterator object will be instantiated and called as such:
 * BSTIterator obj = new BSTIterator(root);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */