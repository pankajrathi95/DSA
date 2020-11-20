/*
#56 - https://leetcode.com/problems/merge-intervals/

Given an array of intervals where intervals[i] = [starti, endi], merge all overlapping intervals, and return an array of the non-overlapping intervals that cover all the intervals in the input.


Example 1:

Input: intervals = [[1,3],[2,6],[8,10],[15,18]]
Output: [[1,6],[8,10],[15,18]]
Explanation: Since intervals [1,3] and [2,6] overlaps, merge them into [1,6].
Example 2:

Input: intervals = [[1,4],[4,5]]
Output: [[1,5]]
Explanation: Intervals [1,4] and [4,5] are considered overlapping.
 

Constraints:

1 <= intervals.length <= 104
intervals[i].length == 2
0 <= starti <= endi <= 104
*/

using System;
using System.Collections.Generic;
using System.Linq;

public class MergeIntervals
{
    public int[][] Merge(int[][] intervals)
    {
        //Sort the Intervals
        Array.Sort(intervals, (x, y) => (x[0] - y[0]));
        IList<int[]> result = new List<int[]>();
        int[] current = intervals[0];
        for (int i = 1; i < intervals.Length; i++)
        {
            //Check if the current element we have also lies in the interval. We need to merge the interval
            if (current[1] >= intervals[i][0] && current[1] <= intervals[i][1])
            {
                current[0] = Math.Min(current[0], intervals[i][0]);
                current[1] = Math.Max(current[1], intervals[i][1]);
            }
            // else if check if it lies outside the current interval, then just insert the current element in the result array and make the current as the current element
            else if (current[1] <= intervals[i][0] && current[1] <= intervals[i][1])
            {
                result.Add(current);
                current = intervals[i];
            }
        }

        result.Add(current);
        return result.ToArray();
    }
}