/*
Given two lists of closed intervals, each list of intervals is pairwise disjoint and in sorted order.

Return the intersection of these two interval lists.

(Formally, a closed interval [a, b] (with a <= b) denotes the set of real numbers x with a <= x <= b.  The intersection of two closed intervals is a set of real numbers that is either empty, or can be represented as a closed interval.  For example, the intersection of [1, 3] and [2, 4] is [2, 3].)

 

Example 1:



Input: A = [[0,2],[5,10],[13,23],[24,25]], B = [[1,5],[8,12],[15,24],[25,26]]
Output: [[1,2],[5,5],[8,10],[15,23],[24,24],[25,25]]
Reminder: The inputs and the desired output are lists of Interval objects, and not arrays or lists.
 

Note:

0 <= A.length < 1000
0 <= B.length < 1000
0 <= A[i].start, A[i].end, B[i].start, B[i].end < 10^9
NOTE: input types have been changed on April 15, 2019. Please reset to default code definition to get new method signature.
*/
using System;
using System.Collections;
using System.Collections.Generic;

public class IntervalListIntersections
{
    // public int[][] IntervalIntersection(int[][] A, int[][] B)
    // {
    //     int length = A[A.Length - 1][1] > B[B.Length - 1][1] ? A[A.Length - 1][1] : B[B.Length - 1][1];
    //     int start = A[0][0] < B[0][0] ? A[0][0] : B[0][0];
    //     int end = start;
    //     int index = 0;
    //     bool flag = false;
    //     int[][] C = new int[A.Length][];
    //     for (int i = start; i <= length; i++)
    //     {
    //         if (i >= A[index][0] && i <= A[index][1] && i >= B[index][0] && i <= B[index][1])
    //         {
    //             end++;
    //             flag = true;
    //         }
    //         else if (flag)
    //         {
    //             C[index] = new int[] { start, end - 1 };
    //             start = end = end + 1;
    //             flag = false;
    //             index++;
    //         }
    //         else
    //         {
    //             start++;
    //             end++;
    //         }
    //     }

    //     return C;
    // }

    public int[][] IntervalIntersection(int[][] A, int[][] B)
    {
        List<int[]> ans = new List<int[]>();
        int i = 0, j = 0;

        while (i < A.Length && j < B.Length)
        {
            // Let's check if A[i] intersects B[j].
            // lo - the startpoint of the intersection
            // hi - the endpoint of the intersection
            int lo = Math.Max(A[i][0], B[j][0]);
            int hi = Math.Min(A[i][1], B[j][1]);
            if (lo <= hi)
                ans.Add(new int[] { lo, hi });

            // Remove the interval with the smallest endpoint
            if (A[i][1] < B[j][1])
                i++;
            else
                j++;
        }

        return ans.ToArray();
        //return ans.ToArray(new int[ans.Count][]);
    }
}