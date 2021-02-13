using System;
using System.Diagnostics;
using Prototype;

namespace DataStructures
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!");
            var watch = new Stopwatch();
            watch.Start();
            //start here   
            MergeKSortedLists.ListNode[] list = new MergeKSortedLists.ListNode[3];

            list[0] = new MergeKSortedLists.ListNode(1, new MergeKSortedLists.ListNode(4, new MergeKSortedLists.ListNode(5, null)));
            list[1] = new MergeKSortedLists.ListNode(1, new MergeKSortedLists.ListNode(3, new MergeKSortedLists.ListNode(4, null)));
            list[2] = new MergeKSortedLists.ListNode(2, new MergeKSortedLists.ListNode(6, null));

            MergeKSortedLists mergeKSortedLists = new MergeKSortedLists();
            mergeKSortedLists.MergeKLists(list);

            //end here
            watch.Stop();
            Console.WriteLine("Time Taken: " + watch.ElapsedMilliseconds + " ms");
        }
    }
}