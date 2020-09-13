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

            InsertInterval insertInterval = new InsertInterval();
            int[][] input = new int[2][];
            input[0] = new int[] { 1, 3 };
            input[1] = new int[] { 6, 9 };

            insertInterval.Insert(input, new int[] { 2, 5 });

            CombinationSumIII combinationSumIII = new CombinationSumIII();
            combinationSumIII.CombinationSum3(3, 7);

            BullsandCows bullsandCows = new BullsandCows();
            bullsandCows.GetHint("1121", "1221");

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

            Successor.TreeNode rot = new Successor.TreeNode(4);

        }
    }
}
