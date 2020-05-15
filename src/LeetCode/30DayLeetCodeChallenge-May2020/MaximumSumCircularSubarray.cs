/*
Given a circular array C of integers represented by A, find the maximum possible sum of a non-empty subarray of C.

Here, a circular array means the end of the array connects to the beginning of the array.  (Formally, C[i] = A[i] when 0 <= i < A.length, and C[i+A.length] = C[i] when i >= 0.)

Also, a subarray may only include each element of the fixed buffer A at most once.  (Formally, for a subarray C[i], C[i+1], ..., C[j], there does not exist i <= k1, k2 <= j with k1 % A.length = k2 % A.length.)

 

Example 1:

Input: [1,-2,3,-2]
Output: 3
Explanation: Subarray [3] has maximum sum 3
Example 2:

Input: [5,-3,5]
Output: 10
Explanation: Subarray [5,5] has maximum sum 5 + 5 = 10
Example 3:

Input: [3,-1,2,-1]
Output: 4
Explanation: Subarray [2,-1,3] has maximum sum 2 + (-1) + 3 = 4
Example 4:

Input: [3,-2,2,-3]
Output: 3
Explanation: Subarray [3] and [3,-2,2] both have maximum sum 3
Example 5:

Input: [-2,-3,-1]
Output: -1
Explanation: Subarray [-1] has maximum sum -1
 

Note:

-30000 <= A[i] <= 30000
1 <= A.length <= 30000
   Hide Hint #1  
For those of you who are familiar with the Kadane's algorithm, think in terms of that. For the newbies, Kadane's algorithm is used to finding the maximum sum subarray from a given array. This problem is a twist on that idea and it is advisable to read up on that algorithm first before starting this problem. Unless you already have a great algorithm brewing up in your mind in which case, go right ahead!
   Hide Hint #2  
What is an alternate way of representing a circular array so that it appears to be a straight array? Essentially, there are two cases of this problem that we need to take care of. Let's look at the figure below to understand those two cases:

   Hide Hint #3  
The first case can be handled by the good old Kadane's algorithm. However, is there a smarter way of going about handling the second case as well?
*/

using System;
using System.Linq;

public class MaximumSumCircularSubarray
{
    //not optimized solution
    public int MaxSubarraySumCircular(int[] A)
    {
        if (A.Length == 1)
        {
            return A[0];
        }

        int max_current = A[0], max_global = A[0], front = 0, rear = 1;
        for (int i = 0; i < A.Length * A.Length; i++)
        {

            if (i == 0 && front == 0)
            {
                max_current = max_global = A[front];
                rear = front + 1;
                continue;
            }

            int index = rear = i % A.Length;
            if (front == rear)
            {
                front++;
                rear = (front + 1) % A.Length;
                if (front >= A.Length)
                {
                    break;
                }
                max_current = A[front];
                i = i + 1;
                continue;
            }

            max_current = Math.Max(A[index], max_current + A[index]);

            if (max_current > max_global)
            {
                max_global = max_current;
            }
        }

        return max_global;
    }

    public int MaxSubarraySumCircular_Optimized(int[] A)
    {
        int min = Int32.MinValue;
        bool positive = false;
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] >= 0)
            {
                positive = true;
                break;
            }
            else
            {
                if (A[i] > min)
                {
                    min = A[i];
                }
            }
        }
        if (!positive)
        {
            return min;
        }
        for (int i = 0; i < A.Length; i++)
        {
            A[i] = -A[i];
        }

        // run Kadane's algorithm on modified array
        int negMaxSum = Kadane(A);

        // restore the array
        for (int i = 0; i < A.Length; i++)
        {
            A[i] = -A[i];
        }
        return Math.Max(Kadane(A), A.Sum() + negMaxSum);
    }

    static int Kadane(int[] a)
    {
        int sum = 0;
        int maxSum = 0;
        int firstIndex = -1;

        for (int i = 0; i < a.Length; i++)
        {
            sum += a[i];
            if (sum < 0)
            {
                sum = 0;
            }
            else
            {
                maxSum = Math.Max(sum, maxSum);
                if (firstIndex == -1)
                    firstIndex = i;
            }
        }
        // starting again from 0 till firstIndex.
        for (int i = 0; i < firstIndex; i++)
        {
            sum += a[i];
            if (sum < 0)
            {
                sum = 0;
            }
            else
            {
                maxSum = Math.Max(sum, maxSum);
            }
        }
        return maxSum;
    }
}