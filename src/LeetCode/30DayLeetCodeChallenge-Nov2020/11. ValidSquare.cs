/*
#593 - https://leetcode.com/problems/valid-square/
Given the coordinates of four points in 2D space, return whether the four points could construct a square.

The coordinate (x,y) of a point is represented by an integer array with two integers.

Example:

Input: p1 = [0,0], p2 = [1,1], p3 = [1,0], p4 = [0,1]
Output: True
 

Note:

All the input integers are in the range [-10000, 10000].
A valid square has four equal sides with positive length and four equal angles (90-degree angles).
Input points have no order.
 
*/

using System;

public class ValidSquare
{
    public bool FindValidSquare(int[] p1, int[] p2, int[] p3, int[] p4)
    {
        if (p1[0] == p2[0] && p1[1] == p2[1] && p2[0] == p3[0] && p2[1] == p3[1] && p3[0] == p4[0] && p3[1] == p4[1])
        {
            return false;
        }

        long[] distances = new long[] { GetDistance(p1, p2), GetDistance(p1, p3), GetDistance(p1, p4), GetDistance(p2, p3), GetDistance(p2, p4), GetDistance(p3, p4) };

        Array.Sort(distances);
        if ((distances[0] == distances[1]) &&
            (distances[1] == distances[2]) &&
            (distances[2] == distances[3]) &&
            (distances[3] == distances[0]) &&
            (distances[4] == distances[5]))
        {
            return true;
        }

        return false;
    }

    private long GetDistance(int[] p1, int[] p2)
    {
        return (long)(Math.Pow(p2[0] - p1[0], 2) + Math.Pow(p2[1] - p1[1], 2));
    }
}