/*
#1288 - https://leetcode.com/problems/remove-covered-intervals/
Given a list of intervals, remove all intervals that are covered by another interval in the list.

Interval [a,b) is covered by interval [c,d) if and only if c <= a and b <= d.

After doing so, return the number of remaining intervals.

 

Example 1:

Input: intervals = [[1,4],[3,6],[2,8]]
Output: 2
Explanation: Interval [3,6] is covered by [2,8], therefore it is removed.
Example 2:

Input: intervals = [[1,4],[2,3]]
Output: 1
Example 3:

Input: intervals = [[0,10],[5,12]]
Output: 2
Example 4:

Input: intervals = [[3,10],[4,10],[5,11]]
Output: 2
Example 5:

Input: intervals = [[1,2],[1,4],[3,4]]
Output: 1
 

Constraints:

1 <= intervals.length <= 1000
intervals[i].length == 2
0 <= intervals[i][0] < intervals[i][1] <= 10^5
All the intervals are unique.
*/

using System.Collections.Generic;
using System.Linq;

public class RemoveCoveredIntervals
{
    //Non-sorting technique (runs faster than the sorting technique)
    public int RemoveCoveredIntervalss(int[][] intervals)
    {
        List<int[]> interval = intervals.ToList();
        for (int i = 0; i < interval.Count; i++)
        {
            int a = interval[i][0];
            int b = interval[i][1];
            for (int j = i + 1; j < interval.Count; j++)
            {
                int c = interval[j][0];
                int d = interval[j][1];

                if (c <= a && b <= d)
                {
                    interval.Remove(interval[i]);
                    i--;
                    break;
                }

                if (a <= c && d <= b)
                {
                    interval.Remove(interval[j]);
                    j--;
                }
            }
        }

        return interval.Count;
    }


    //using the sorting technique
    public int RemoveTheCoveredIntervals(int[][] intervals)
    {
        List<int[]> interval = intervals.ToList();
        interval.Sort((a, b) => a[0] - b[0]);

        for (int i = 0; i < interval.Count - 1; i++)
        {
            int a = interval[i][0];
            int b = interval[i][1];
            int c = interval[i + 1][0];
            int d = interval[i + 1][1];

            if (c <= a && b <= d)
            {
                interval.Remove(interval[i]);
                i--;
            }

            if (a <= c && d <= b)
            {
                interval.Remove(interval[i + 1]);
                i--;
            }
        }

        return interval.Count;
    }
}