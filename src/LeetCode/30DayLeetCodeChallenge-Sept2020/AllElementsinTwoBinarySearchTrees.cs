/*
Given two binary search trees root1 and root2.

Return a list containing all the integers from both trees sorted in ascending order. 

Example 1:


Input: root1 = [2,1,4], root2 = [1,0,3]
Output: [0,1,1,2,3,4]
Example 2:

Input: root1 = [0,-10,10], root2 = [5,1,7,0,2]
Output: [-10,0,0,1,2,5,7,10]
Example 3:

Input: root1 = [], root2 = [5,1,7,0,2]
Output: [0,1,2,5,7]
Example 4:

Input: root1 = [0,-10,10], root2 = []
Output: [-10,0,10]
Example 5:


Input: root1 = [1,null,8], root2 = [8,1]
Output: [1,1,8,8]
*/


using System.Collections.Generic;
public class AllElementsinTwoBinarySearchTrees
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
    public IList<int> GetAllElements(TreeNode root1, TreeNode root2)
    {
        IList<int> list1 = new List<int>();
        IList<int> list2 = new List<int>();
        Traverse(root1, list1);
        Traverse(root2, list2);
        IList<int> list = new List<int>();
        int i = 0, j = 0;
        while (i < list1.Count && j < list2.Count)
        {
            if (list1[i] > list2[j])
            {
                list.Add(list2[j++]);
            }
            else
            {
                list.Add(list1[i++]);
            }
        }

        while (i < list1.Count)
        {
            list.Add(list1[i++]);
        }

        while (j < list2.Count)
        {
            list.Add(list2[j++]);
        }

        return list;
    }

    private void Traverse(TreeNode root, IList<int> list)
    {
        if (root == null)
        {
            return;
        }

        Traverse(root.left, list);
        list.Add(root.val);
        Traverse(root.right, list);
    }
}