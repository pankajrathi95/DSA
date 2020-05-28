/*
https://www.hackerrank.com/challenges/crush/problem

Starting with a 1-indexed array of zeros and a list of operations, for each operation add a value to each of the array element between two given indices, inclusive. Once all operations have been performed, return the maximum value in your array.

For example, the length of your array of zeros . Your list of queries is as follows:

    a b k
    1 5 3
    4 8 7
    6 9 1
Add the values of  between the indices  and  inclusive:

index->	 1 2 3  4  5 6 7 8 9 10
	[0,0,0, 0, 0,0,0,0,0, 0]
	[3,3,3, 3, 3,0,0,0,0, 0]
	[3,3,3,10,10,7,7,7,0, 0]
	[3,3,3,10,10,8,8,8,1, 0]
The largest value is  after all operations are performed.

Function Description

Complete the function arrayManipulation in the editor below. It must return an integer, the maximum value in the resulting array.

arrayManipulation has the following parameters:

n - the number of elements in your array
queries - a two dimensional array of queries where each queries[i] contains three integers, a, b, and k.
*/

using System;
using System.Linq;

class ArrayManipulation
{
    public static long CalArrayManipulation(int n, int[][] queries)
    {
        long[] values = new long[n];
        for (int i = 0; i < queries.Length; i++)
        {
            values[queries[i][0] - 1] += queries[i][2];

            if (queries[i][1] + 1 <= n)
            {
                values[queries[i][1]] -= queries[i][2];
            }
        }

        long max = values[0];
        for (int i = 1; i < values.Length; i++)
        {
            values[i] += values[i - 1];
            max = Math.Max(max, values[i]);
        }

        return max;
    }
}