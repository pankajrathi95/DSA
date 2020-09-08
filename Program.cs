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

            SumofRootToLeafBinaryNumbers.TreeNode root = new SumofRootToLeafBinaryNumbers.TreeNode(1, null, new SumofRootToLeafBinaryNumbers.TreeNode(0));

            SumofRootToLeafBinaryNumbers sumofRootToLeafBinaryNumbers = new SumofRootToLeafBinaryNumbers();
            sumofRootToLeafBinaryNumbers.SumRootToLeaf(root);

            // ListofDepths.TreeNode left1 = new ListofDepths.TreeNode(4);
            // ListofDepths.TreeNode right1 = new ListofDepths.TreeNode(5);

            // ListofDepths.TreeNode left2 = new ListofDepths.TreeNode(6, new ListofDepths.TreeNode(7));
            // //ListofDepths.TreeNode right2 = new ListofDepths.TreeNode(7);

            // ListofDepths.TreeNode left = new ListofDepths.TreeNode(2, left1, right1);
            // ListofDepths.TreeNode right = new ListofDepths.TreeNode(3, left2);

            // ListofDepths.TreeNode root = new ListofDepths.TreeNode(1, left, right);

            // ListofDepths listofDepths = new ListofDepths();
            // listofDepths.NodesatDepth(root);



        }
    }
}
