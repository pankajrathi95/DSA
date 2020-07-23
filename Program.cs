using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            BinaryTreeZigzagLevelOrder.TreeNode root = new BinaryTreeZigzagLevelOrder.TreeNode(
                3,
                new BinaryTreeZigzagLevelOrder.TreeNode(9, new BinaryTreeZigzagLevelOrder.TreeNode(3, null, null), new BinaryTreeZigzagLevelOrder.TreeNode(4, null, null)),
                new BinaryTreeZigzagLevelOrder.TreeNode(20, new BinaryTreeZigzagLevelOrder.TreeNode(15, null, null), new BinaryTreeZigzagLevelOrder.TreeNode(7, null, null))
                    );

            BinaryTreeZigzagLevelOrder binary = new BinaryTreeZigzagLevelOrder();
            binary.ZigzagLevelOrder(root);
        }
    }
}
