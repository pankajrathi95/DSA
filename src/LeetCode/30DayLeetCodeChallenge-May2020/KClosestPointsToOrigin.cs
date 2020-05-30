using System;
using System.Collections.Generic;

public class KClosestPointsToOrigin
{
    public int[][] KClosest(int[][] points, int K)
    {
        double[] distances = new double[points.Length];
        int[][] result = new int[K][];
        Dictionary<double, List<int[]>> dictionary = new Dictionary<double, List<int[]>>();

        for (int i = 0; i < points.Length; i++)
        {
            distances[i] = DistanceBetweenPoints(points[i][0], points[i][1]);
            if (!dictionary.ContainsKey(distances[i]))
            {
                List<int[]> value = new List<int[]>();
                value.Add(points[i]);
                dictionary.Add(distances[i], value);
            }
            else
            {
                dictionary[distances[i]].Add(points[i]);
            }
        }

        Array.Sort(distances);

        while (K != 0)
        {
            int[][] temp = dictionary[distances[K - 1]].ToArray();

            for (int i = 0; i < temp.Length; i++)
            {
                result[K - 1] = dictionary[distances[K - 1]][i];
                K--;
            }
        }

        return result;
    }

    public double DistanceBetweenPoints(int x, int y)
    {
        return Math.Sqrt(Math.Abs(x * x) + Math.Abs(y * y));
    }
}