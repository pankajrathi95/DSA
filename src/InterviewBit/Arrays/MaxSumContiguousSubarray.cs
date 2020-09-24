/*
Find the contiguous subarray within an array, A of length N which has the largest sum.

Input Format:

The first and the only argument contains an integer array, A.
Output Format:

Return an integer representing the maximum possible sum of the contiguous subarray.
Constraints:

1 <= N <= 1e6
-1000 <= A[i] <= 1000
For example:

Input 1:
    A = [1, 2, 3, 4, -10]

Output 1:
    10

Explanation 1:
    The subarray [1, 2, 3, 4] has the maximum possible sum of 10.

Input 2:
    A = [-2, 1, -3, 4, -1, 2, 1, -5, 4]

Output 2:
    6

Explanation 2:
    The subarray [4,-1,2,1] has the maximum possible sum of 6.
*/

using System;
using System.Collections.Generic;

class MaxSumContiguousSubarray
{
    //Non-Optimal Solution
    public int MaxSubArray(List<int> A)
    {
        int sum = int.MinValue;
        for (int i = 0; i < A.Count; i++)
        {
            int temp = 0;
            for (int j = i; j < A.Count; j++)
            {
                temp += A[j];
                sum = Math.Max(sum, temp);
            }
        }

        return sum;
    }

    public int MaxSubArraySum(List<int> A)
    {
        int sum = A[0], tempAns = A[0];
        for (int i = 1; i < A.Count; i++)
        {
            tempAns = Math.Max(tempAns + A[i], A[i]);
            sum = Math.Max(sum, tempAns);
        }

        return sum;
    }
}
