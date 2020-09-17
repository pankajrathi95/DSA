using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace DataStructures
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!");
            var watch = new Stopwatch();
            watch.Start();
            TripleStep tripleStep = new TripleStep();
            Console.WriteLine(tripleStep.CountWays(1));
            Console.WriteLine(tripleStep.CountWays(2));
            Console.WriteLine(tripleStep.CountWays(3));
            Console.WriteLine(tripleStep.CountWays(4));
            Console.WriteLine(tripleStep.CountWays(10));
            //Console.WriteLine(tripleStep.CountWays(60));
            watch.Stop();
            Console.WriteLine("Time Taken: " + watch.ElapsedMilliseconds + " ms");
            // PathSumII.TreeNode left = new PathSumII.TreeNode(5, new PathSumII.TreeNode(3, new PathSumII.TreeNode(3), new PathSumII.TreeNode(-2)), new PathSumII.TreeNode(2, null, new PathSumII.TreeNode(1)));
            // PathSumII.TreeNode right = new PathSumII.TreeNode(-3, null, new PathSumII.TreeNode(11));
            // PathSumII.TreeNode root = new PathSumII.TreeNode(10, left, right);

            // PathSumII.TreeNode root1 = new PathSumII.TreeNode(1, null, new PathSumII.TreeNode(2, null, new PathSumII.TreeNode(3, null, new PathSumII.TreeNode(4, null, new PathSumII.TreeNode(5)))));
            // PathSumII pathWithSum = new PathSumII();
            // pathWithSum.PathSum(root1, 3);
        }
    }
}
