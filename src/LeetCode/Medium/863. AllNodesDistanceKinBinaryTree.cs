/*
#863 - https://leetcode.com/problems/all-nodes-distance-k-in-binary-tree/
We are given a binary tree (with root node root), a target node, and an integer value K.

Return a list of the values of all nodes that have a distance K from the target node.  The answer can be returned in any order.

 

Example 1:

Input: root = [3,5,1,6,2,0,8,null,null,7,4], target = 5, K = 2

Output: [7,4,1]

Explanation: 
The nodes that are a distance 2 from the target node (with value 5)
have values 7, 4, and 1.



Note that the inputs "root" and "target" are actually TreeNodes.
The descriptions of the inputs above are just serializations of these objects.
 

Note:

The given tree is non-empty.
Each node in the tree has unique values 0 <= node.val <= 500.
The target node is a node in the tree.
0 <= K <= 1000.
*/


using System.Collections.Generic;
public class AllNodesDistanceKinBinaryTree
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
    public IList<int> DistanceK(TreeNode root, TreeNode target, int K)
    {
        IList<int> result = new List<int>();
        HashSet<TreeNode> visited = new HashSet<TreeNode>();
        Dictionary<TreeNode, TreeNode> parents = new Dictionary<TreeNode, TreeNode>();
        Dfs(root, null, parents);
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(target);
        visited.Add(target);
        while (queue.Count != 0)
        {
            if (K == 0)
            {
                while (queue.Count != 0)
                {
                    result.Add(queue.Dequeue().val);
                }

                return result;
            }

            int size = queue.Count;
            for (int i = 0; i < size; i++)
            {
                TreeNode current = queue.Dequeue();
                if (current.left != null && !visited.Contains(current.left))
                {
                    queue.Enqueue(current.left);
                    visited.Add(current.left);
                }

                if (current.right != null && !visited.Contains(current.right))
                {
                    queue.Enqueue(current.right);
                    visited.Add(current.right);
                }

                if (parents[current] != null && !visited.Contains(parents[current]))
                {
                    queue.Enqueue(parents[current]);
                    visited.Add(parents[current]);
                }
            }

            K--;
        }

        return result;
    }

    private void Dfs(TreeNode node, TreeNode parent, Dictionary<TreeNode, TreeNode> parents)
    {
        if (node != null)
        {
            parents.Add(node, parent);
            Dfs(node.left, node, parents);
            Dfs(node.right, node, parents);
        }
    }
}