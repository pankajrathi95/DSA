using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!");
            PathWithSum.TreeNode left = new PathWithSum.TreeNode(5, new PathWithSum.TreeNode(3, new PathWithSum.TreeNode(3), new PathWithSum.TreeNode(-2)), new PathWithSum.TreeNode(2, null, new PathWithSum.TreeNode(1)));
            PathWithSum.TreeNode right = new PathWithSum.TreeNode(-3, null, new PathWithSum.TreeNode(11));
            PathWithSum.TreeNode root = new PathWithSum.TreeNode(10, left, right);

            PathWithSum.TreeNode root1 = new PathWithSum.TreeNode(1, null, new PathWithSum.TreeNode(2, null, new PathWithSum.TreeNode(3, null, new PathWithSum.TreeNode(4, null, new PathWithSum.TreeNode(5)))));
            PathWithSum pathWithSum = new PathWithSum();
            pathWithSum.PathSum(root1, 3);
        }
    }
}
