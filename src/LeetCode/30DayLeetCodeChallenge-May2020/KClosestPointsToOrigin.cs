/*
#973 - https://leetcode.com/problems/k-closest-points-to-origin/

We have a list of points on the plane.  Find the K closest points to the origin (0, 0).

(Here, the distance between two points on a plane is the Euclidean distance.)

You may return the answer in any order.  The answer is guaranteed to be unique (except for the order that it is in.)

 

Example 1:

Input: points = [[1,3],[-2,2]], K = 1
Output: [[-2,2]]
Explanation: 
The distance between (1, 3) and the origin is sqrt(10).
The distance between (-2, 2) and the origin is sqrt(8).
Since sqrt(8) < sqrt(10), (-2, 2) is closer to the origin.
We only want the closest K = 1 points from the origin, so the answer is just [[-2,2]].
Example 2:

Input: points = [[3,3],[5,-1],[-2,4]], K = 2
Output: [[3,3],[-2,4]]
(The answer [[-2,4],[3,3]] would also be accepted.)
 

Note:

1 <= K <= points.length <= 10000
-10000 < points[i][0] < 10000
-10000 < points[i][1] < 10000
*/

using System;
using System.Collections.Generic;

public class KClosestPointsToOrigin
{
    public int[][] KClosest(int[][] points, int K)
    {
        double[] distances = new double[points.Length];
        //Store the distances in an array
        for (int i = 0; i < distances.Length; i++)
        {
            distances[i] = GetDistance(points[i][0], points[i][1]);
        }

        //Sort the array and keep the kth value in a variable. Any point with distance
        //less than or equal to this distance we need to store it.
        Array.Sort(distances);
        double distK = distances[K - 1];
        int[][] result = new int[K][];
        int index = 0;
        for (int i = 0; i < points.Length && index < K; i++)
        {
            if (GetDistance(points[i][0], points[i][1]) <= distK)
            {
                result[index++] = points[i];
            }
        }

        return result;
    }

    private double GetDistance(int x, int y)
    {
        return Math.Sqrt((x * x) + (y * y));
    }
}