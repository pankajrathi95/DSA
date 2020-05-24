using System;
using System.Collections.Generic;
using static MiddleLinkedList;

namespace DataStructures
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] preorder = new int[] { 8, 5, 1, 7, 10, 12 };
            BstFromPreOrder bst = new BstFromPreOrder();
            bst.BstFromPreorder(preorder);
        }
    }
}
