/*
#449 - https://leetcode.com/problems/serialize-and-deserialize-bst/
Serialization is converting a data structure or object into a sequence of bits so that it can be stored in a file or memory buffer, or transmitted across a network connection link to be reconstructed later in the same or another computer environment.

Design an algorithm to serialize and deserialize a binary search tree. There is no restriction on how your serialization/deserialization algorithm should work. You need to ensure that a binary search tree can be serialized to a string, and this string can be deserialized to the original tree structure.

The encoded string should be as compact as possible.

 

Example 1:

Input: root = [2,1,3]
Output: [2,1,3]
Example 2:

Input: root = []
Output: []
 

Constraints:

The number of nodes in the tree is in the range [0, 104].
0 <= Node.val <= 104
The input tree is guaranteed to be a binary search tree.
*/


using System;
using System.Text;

public class Codec
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
    // Encodes a tree to a single string.
    public string serialize(TreeNode root)
    {
        StringBuilder sb = new StringBuilder();

        Solve(root, sb);
        return sb.ToString();
    }

    private void Solve(TreeNode root, StringBuilder sb)
    {
        if (root == null)
        {
            return;
        }

        sb.Append(root.val.ToString() + ' ');
        Solve(root.left, sb);
        Solve(root.right, sb);
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data)
    {
        string[] arr = data.Trim().Split(' ');
        if (arr.Length == 1 && arr[0].Equals(""))
        {
            return null;
        }

        TreeNode root = new TreeNode(Convert.ToInt32(arr[0]));
        for (int i = 1; i < arr.Length; i++)
        {
            root = BST(root, Convert.ToInt32(arr[i]));
        }

        return root;
    }

    private TreeNode BST(TreeNode root, int data)
    {
        if (root == null)
        {
            return new TreeNode(data);
        }

        if (root.val > data)
        {
            root.left = BST(root.left, data);
        }
        else
        {
            root.right = BST(root.right, data);
        }

        return root;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec ser = new Codec();
// Codec deser = new Codec();
// String tree = ser.serialize(root);
// TreeNode ans = deser.deserialize(tree);
// return ans;