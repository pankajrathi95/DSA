/*
https://leetcode.com/problems/meeting-rooms/
Given an array of meeting time intervals where intervals[i] = [starti, endi], determine if a person could attend all meetings.

 

Example 1:

Input: intervals = [[0,30],[5,10],[15,20]]
Output: false
Example 2:

Input: intervals = [[7,10],[2,4]]
Output: true
 

Constraints:

0 <= intervals.length <= 104
intervals[i].length == 2
0 <= starti < endi <= 106
*/

using System;

public class MeetingRooms
{
    public bool CanAttendMeetings(int[][] intervals)
    {
        Array.Sort(intervals, (a, b) =>
        {
            return a[0] - b[0];
        });

        int maxEnd = 0;
        for (int i = 0; i < intervals.Length - 1; i++)
        {
            maxEnd = Math.Max(maxEnd, intervals[i][1]);
            if (intervals[i + 1][0] < maxEnd)
            {
                return false;
            }
        }

        return true;
    }
}