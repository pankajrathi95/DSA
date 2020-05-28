/*
https://www.hackerrank.com/challenges/2d-array/problem
*/

using System;

class TwoDArray
{
    public static int HourglassSum(int[][] arr)
    {
        int max = int.MinValue;
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                int temp = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                max = Math.Max(max, temp);
            }
        }

        return max;
    }
}