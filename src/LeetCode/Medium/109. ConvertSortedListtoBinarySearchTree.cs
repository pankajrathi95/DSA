/*
#109 - https://leetcode.com/problems/convert-sorted-list-to-binary-search-tree/

Given the head of a singly linked list where elements are sorted in ascending order, convert it to a height balanced BST.

For this problem, a height-balanced binary tree is defined as a binary tree in which the depth of the two subtrees of every node never differ by more than 1.

 

Example 1:


Input: head = [-10,-3,0,5,9]
Output: [0,-3,9,-10,null,5]
Explanation: One possible answer is [0,-3,9,-10,null,5], which represents the shown height balanced BST.
Example 2:

Input: head = []
Output: []
Example 3:

Input: head = [0]
Output: [0]
Example 4:

Input: head = [1,3]
Output: [3,1]
 

Constraints:

The number of nodes in head is in the range [0, 2 * 104].
-10^5 <= Node.val <= 10^5
*/


using System.Collections.Generic;

public class ConvertSortedListtoBinarySearchTree
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
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public TreeNode SortedListToBST(ListNode head)
    {
        if (head == null)
        {
            return null;
        }

        List<int> vals = new List<int>();
        while (head != null)
        {
            vals.Add(head.val);
            head = head.next;
        }

        return Solve(vals.ToArray(), 0, vals.Count - 1);
    }

    public TreeNode Solve(int[] nums, int left, int right)
    {
        if (left > right)
        {
            return null;
        }

        int mid = (left + right) / 2;
        TreeNode root = new TreeNode(nums[mid]);
        root.left = Solve(nums, left, mid - 1);
        root.right = Solve(nums, mid + 1, right);

        return root;
    }
}