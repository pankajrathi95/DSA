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
            DeleteNodeinBST.TreeNode left = new DeleteNodeinBST.TreeNode(3, new DeleteNodeinBST.TreeNode(2), new DeleteNodeinBST.TreeNode(4));
            DeleteNodeinBST.TreeNode right = new DeleteNodeinBST.TreeNode(6, null, new DeleteNodeinBST.TreeNode(7));

            DeleteNodeinBST.TreeNode root = new DeleteNodeinBST.TreeNode(5, left, right);

            DeleteNodeinBST bST = new DeleteNodeinBST();
            bST.DeleteNode(root, 3);
        }
    }
}
