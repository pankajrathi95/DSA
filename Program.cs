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
            int[][] graph = new int[][] {
                new int[] {1, 3},
                new int[] {0,2},
                new int[] {1,3},
                new int[] {0,2}
            };



            MergeKSortedLists.ListNode[] list = new MergeKSortedLists.ListNode[3];
            IsGraphBipartite iss = new IsGraphBipartite();
            Console.WriteLine(iss.IsBipartite(graph));

            //end here
            watch.Stop();
            Console.WriteLine("Time Taken: " + watch.ElapsedMilliseconds + " ms");
        }
    }
}