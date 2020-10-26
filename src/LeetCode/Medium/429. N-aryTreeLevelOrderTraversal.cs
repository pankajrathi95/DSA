/*
https://leetcode.com/problems/n-ary-tree-level-order-traversal/

Given an n-ary tree, return the level order traversal of its nodes' values.

Nary-Tree input serialization is represented in their level order traversal, each group of children is separated by the null value (See examples).

 

Example 1:



Input: root = [1,null,3,2,4,null,5,6]
Output: [[1],[3,2,4],[5,6]]
Example 2:



Input: root = [1,null,2,3,4,5,null,null,6,7,null,8,null,9,10,null,null,11,null,12,null,13,null,null,14]
Output: [[1],[2,3,4,5],[6,7,8,9,10],[11,12,13],[14]]
 

Constraints:

The height of the n-ary tree is less than or equal to 1000
The total number of nodes is between [0, 10^4]
*/

using System.Collections.Generic;

public class NaryTreeLevelOrderTraversal
{
    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }
    public IList<IList<int>> LevelOrder(Node root)
    {
        IList<IList<int>> result = new List<IList<int>>();
        Queue<Node> queue = new Queue<Node>();
        if (root == null)
        {
            return result;
        }

        queue.Enqueue(root);
        result.Add(new List<int>() { root.val });
        while (queue.Count != 0)
        {
            int size = queue.Count;
            IList<int> level = new List<int>();
            for (int i = 0; i < size; i++)
            {
                var current = queue.Dequeue();
                foreach (var item in current.children)
                {
                    queue.Enqueue(item);
                    level.Add(item.val);
                }
            }

            if (level.Count != 0)
            {
                result.Add(level);
            }
        }

        return result;
    }
}