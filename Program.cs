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
            PathSumII.TreeNode left = new PathSumII.TreeNode(5, new PathSumII.TreeNode(3, new PathSumII.TreeNode(3), new PathSumII.TreeNode(-2)), new PathSumII.TreeNode(2, null, new PathSumII.TreeNode(1)));
            PathSumII.TreeNode right = new PathSumII.TreeNode(-3, null, new PathSumII.TreeNode(11));
            PathSumII.TreeNode root = new PathSumII.TreeNode(10, left, right);

            PathSumII.TreeNode root1 = new PathSumII.TreeNode(1, null, new PathSumII.TreeNode(2, null, new PathSumII.TreeNode(3, null, new PathSumII.TreeNode(4, null, new PathSumII.TreeNode(5)))));
            PathSumII pathWithSum = new PathSumII();
            pathWithSum.PathSum(root1, 3);
        }
    }
}
