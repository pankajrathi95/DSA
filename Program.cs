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
            // ReorderList.ListNode head =
            // new ReorderList.ListNode(1,
            // new ReorderList.ListNode(2,
            // new ReorderList.ListNode(3,
            // new ReorderList.ListNode(4,
            // new ReorderList.ListNode(5,
            // new ReorderList.ListNode(6,
            // new ReorderList.ListNode(7,
            // null)))))));

            // ReorderList reorderList = new ReorderList();
            // reorderList.ReorderTheList(head);
            int[][] matrix = new int[3][];
            matrix[0] = new int[] { 0, 1, 2 };
            matrix[1] = new int[] { 3, 4, 5 };
            matrix[2] = new int[] { 6, 7, 8 };
            Console.WriteLine(RotateMatrix.RotateTheMatrix(matrix));

        }
    }
}
