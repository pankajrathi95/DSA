/*

*/

using System;
using System.Collections.Generic;

public class MaximumLengthofRepeatedSubarray
{
    //DP approach
    public int FindTheLength(int[] A, int[] B) {
        int[][] dp = new int[A.Length + 1][];
        for (int i = 0 ; i < dp.Length; i++)
        {
            dp[i] = new int[B.Length + 1];
        }
        
        int result = 0;
        for (int i = 0; i < dp.Length; i++)
        {
            for (int j = 0; j < dp[i].Length; j++)
            {
                if (i == 0 || j == 0)
                {
                    dp[i][j] = 0;
                }
                else if (A[i - 1] == B[j - 1])
                {
                    dp[i][j] = dp[i - 1][j - 1] + 1;
                    result = Math.Max(result, dp[i][j]);
                }
                else
                {
                    dp[i][j] = 0;
                }
            }
        }
        
        return result;
    }


    //Timeout (Taking a lot of time)
    public int FindLength(int[] A, int[] B)
    {

        Dictionary<int, IList<int>> values = new Dictionary<int, IList<int>>();
        for (int i = 0; i < A.Length; i++)
        {
            if (values.ContainsKey(A[i]))
            {
                values[A[i]].Add(i);
            }
            else
            {
                values.Add(A[i], new List<int>() { i });
            }
        }

        int result = 0;
        for (int i = 0; i < B.Length; i++)
        {
            int currentMax = 0;
            if (!values.ContainsKey(B[i]))
            {
                continue;
            }

            foreach (var index in values[B[i]])
            {
                currentMax = 0;
                int currentIndexAtA = index, currentIndexAtB = i;
                while (currentIndexAtA < A.Length && currentIndexAtB < B.Length && A[currentIndexAtA] == B[currentIndexAtB])
                {

                    currentIndexAtA++;
                    currentIndexAtB++;
                    currentMax++;
                }

                result = Math.Max(result, currentMax);
            }
        }

        return result;
    }
}