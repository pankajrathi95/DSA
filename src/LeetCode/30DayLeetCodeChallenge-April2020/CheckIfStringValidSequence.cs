/*

Given a binary tree where each path going from the root to any leaf form a valid sequence, check if a given string is a valid sequence in such binary tree. 

We get the given string from the concatenation of an array of integers arr and the concatenation of all values of the nodes along a path results in a sequence in the given binary tree.

 

Example 1:



Input: root = [0,1,0,0,1,0,null,null,1,0,0], arr = [0,1,0,1]
Output: true
Explanation: 
The path 0 -> 1 -> 0 -> 1 is a valid sequence (green color in the figure). 
Other valid sequences are: 
0 -> 1 -> 1 -> 0 
0 -> 0 -> 0
Example 2:



Input: root = [0,1,0,0,1,0,null,null,1,0,0], arr = [0,0,1]
Output: false 
Explanation: The path 0 -> 0 -> 1 does not exist, therefore it is not even a sequence.
Example 3:



Input: root = [0,1,0,0,1,0,null,null,1,0,0], arr = [0,1,1]
Output: false
Explanation: The path 0 -> 1 -> 1 is a sequence, but it is not a valid sequence.
 

Constraints:

1 <= arr.length <= 5000
0 <= arr[i] <= 9
Each node's value is between [0 - 9].
   Hide Hint #1  
Depth-first search (DFS) with the parameters: current node in the binary tree and current position in the array of integers.
   Hide Hint #2  
When reaching at final position check if it is a leaf node.

*/


// Definition for a binary tree node.


public class CheckIfStringValidSequence
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

    public bool IsValidSequence(TreeNode root, int[] arr)
    {
        var current = root;
        return Traverse(current, 0, arr);
    }

    private bool Traverse(TreeNode current, int i, int[] arr)
    {
        if (current == null || i == arr.Length)
        {
            return false;
        }

        if (IsLeafNode(current) && i == arr.Length - 1 && current.val == arr[i])
        {
            return true;
        }

        return current.val == arr[i] && Traverse(current.left, i + 1, arr) || Traverse(current.right, i + 1, arr);

    }

    private bool IsLeafNode(TreeNode node)
    {
        return node.left == null && node.right == null;
    }
}