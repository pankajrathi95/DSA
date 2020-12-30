/*
#1457 - https://leetcode.com/problems/pseudo-palindromic-paths-in-a-binary-tree/

Given a binary tree where node values are digits from 1 to 9. A path in the binary tree is said to be pseudo-palindromic if at least one permutation of the node values in the path is a palindrome.

Return the number of pseudo-palindromic paths going from the root node to leaf nodes.

 

Example 1:



Input: root = [2,3,1,3,1,null,1]
Output: 2 
Explanation: The figure above represents the given binary tree. There are three paths going from the root node to leaf nodes: the red path [2,3,3], the green path [2,1,1], and the path [2,3,1]. Among these paths only red path and green path are pseudo-palindromic paths since the red path [2,3,3] can be rearranged in [3,2,3] (palindrome) and the green path [2,1,1] can be rearranged in [1,2,1] (palindrome).
Example 2:



Input: root = [2,1,1,1,3,null,null,null,null,null,1]
Output: 1 
Explanation: The figure above represents the given binary tree. There are three paths going from the root node to leaf nodes: the green path [2,1,1], the path [2,1,3,1], and the path [2,1]. Among these paths only the green path is pseudo-palindromic since [2,1,1] can be rearranged in [1,2,1] (palindrome).
Example 3:

Input: root = [9]
Output: 1
 

Constraints:

The given binary tree will have between 1 and 10^5 nodes.
Node values are digits from 1 to 9.

Hint 1 : Note that the node values of a path form a palindrome if at most one digit has an odd frequency (parity).
Hint 2 : Use a Depth First Search (DFS) keeping the frequency (parity) of the digits. Once you are in a leaf node check if at most one digit has an odd frequency (parity).
*/


using System.Collections.Generic;
public class PseudoPalindromicPathsinABinaryTree
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
    List<string> result = new List<string>();
    public int PseudoPalindromicPaths(TreeNode root)
    {
        Solve(root, "");
        int count = 0;
        foreach (var res in result)
        {
            if (IsPalindrome(res))
            {
                count++;
            }
        }

        return count;
    }

    public void Solve(TreeNode root, string str)
    {
        if (root == null)
        {
            return;
        }

        str += root.val;
        if (root.left == null && root.right == null)
        {
            result.Add(str);
            str = str.Substring(0, str.Length - 1);
        }

        Solve(root.left, str);
        Solve(root.right, str);
    }

    public bool IsPalindrome(string res)
    {
        Dictionary<int, int> values = new Dictionary<int, int>();
        foreach (var input in res)
        {
            int x = input - '0';
            if (values.ContainsKey(x))
            {
                values[x]++;
            }
            else
            {
                values.Add(x, 1);
            }
        }

        int oddFreq = 0;
        foreach (var kvp in values)
        {
            if (kvp.Value % 2 != 0)
            {
                oddFreq++;
            }
        }

        return oddFreq <= 1 ? true : false;
    }
}