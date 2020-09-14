using System;
using System.Collections.Generic;

public class BSTSequences
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


    public List<LinkedList<int>> FindSequences(TreeNode root)
    {
        List<LinkedList<int>> result = new List<LinkedList<int>>();
        if (root == null)
        {
            result.Add(new LinkedList<int>());
            return result;
        }

        if (root.left == null && root.right == null)
        {
            LinkedList<int> seq = new LinkedList<int>();
            seq.AddLast(root.val);
            result.Add(seq);
            return result;
        }

        LinkedList<int> prefix = new LinkedList<int>();
        prefix.AddLast(root.val);


        List<LinkedList<int>> leftSeq = FindSequences(root.left);
        List<LinkedList<int>> rightSeq = FindSequences(root.right);

        foreach (var left in leftSeq)
        {
            foreach (var right in rightSeq)
            {
                List<LinkedList<int>> weaved = new List<LinkedList<int>>();
                WeavingTheLists(left, right, weaved, prefix);
                foreach (var weave in weaved)
                {
                    result.Add(weave);
                }
            }
        }

        return result;
    }

    private void WeavingTheLists(LinkedList<int> left, LinkedList<int> right, List<LinkedList<int>> weaved, LinkedList<int> prefix)
    {
        if (left.Count == 0 || right.Count == 0)
        {
            LinkedList<int> res = new LinkedList<int>();
            foreach (var item in prefix)
            {
                res.AddLast(item);
            }

            foreach (var item in left)
            {
                res.AddLast(item);
            }

            foreach (var item in right)
            {
                res.AddLast(item);
            }

            weaved.Add(res);
            return;
        }

        int headFirst = left.First.Value;
        left.RemoveFirst();
        prefix.AddLast(headFirst);
        WeavingTheLists(left, right, weaved, prefix);
        prefix.RemoveLast();
        left.AddFirst(headFirst);

        int headSecond = right.First.Value;
        right.RemoveFirst();
        prefix.AddLast(headSecond);
        WeavingTheLists(left, right, weaved, prefix);
        prefix.RemoveLast();
        right.AddFirst(headFirst);
    }
}