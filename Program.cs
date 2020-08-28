using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures
{
    class Program
    {
        Dictionary<int, int> values = new Dictionary<int, int>();


        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!");
            // int k = 0;
            // foreach (var interval in intervals)
            // {
            //     values.Add(interval[0], k++);
            // }


            // ThreeSum threeSum = new ThreeSum();
            // threeSum.Sum(new int[] { -1, 0, 1, 2, -1, 4 });

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
            // int[][] matrix = new int[3][];
            // matrix[0] = new int[] { 1, 1, 2 };
            // matrix[1] = new int[] { 3, 0, 5 };
            // matrix[2] = new int[] { 6, 7, 8 };
            // Console.WriteLine(ZeroMatrix.SetZeroMatrix(matrix));

            // string[] words = new string[] { "ab", "ba", "aaab", "abab", "baa" };
            // StreamofCharacters characters = new StreamofCharacters(words);
            // characters.Query('a');
            // characters.Query('a');
            // characters.Query('a');
            // characters.Query('a');
            // characters.Query('a');


            Console.WriteLine(BinarySearch(2, new int[] { 1, 4, 6, 7, 8, 11, 15, 19, 78 }, 0, 6, 3));
            //return new int[] { };
        }

        private static int BinarySearch(int item, int[] newIntervals, int start, int end, int prevMid)
        {
            if (start > end)
            {
                return -1;
            }
            int mid = (start + end) / 2;
            if (newIntervals[mid] == item)
            {
                return newIntervals[mid];
            }

            if (newIntervals[mid] > item)
            {
                end = mid - 1;
            }
            else
            {
                start = mid + 1;
            }

            if (newIntervals[prevMid] > newIntervals[mid])
            {
                return newIntervals[prevMid];
            }

            return BinarySearch(item, newIntervals, start, end, mid);
        }
    }
}
