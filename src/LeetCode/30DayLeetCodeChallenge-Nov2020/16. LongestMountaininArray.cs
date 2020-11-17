/*
#845 - https://leetcode.com/problems/longest-mountain-in-array/

Let's call any (contiguous) subarray B (of A) a mountain if the following properties hold:

B.length >= 3
There exists some 0 < i < B.length - 1 such that B[0] < B[1] < ... B[i-1] < B[i] > B[i+1] > ... > B[B.length - 1]
(Note that B could be any subarray of A, including the entire array A.)

Given an array A of integers, return the length of the longest mountain. 

Return 0 if there is no mountain.

Example 1:

Input: [2,1,4,7,3,2,5]
Output: 5
Explanation: The largest mountain is [1,4,7,3,2] which has length 5.
Example 2:

Input: [2,2,2]
Output: 0
Explanation: There is no mountain.
Note:

0 <= A.length <= 10000
0 <= A[i] <= 10000
Follow up:

Can you solve it using only one pass?
Can you solve it in O(1) space?
*/

using System;

public class LongestMountaininArray
{
    public int LongestMountain(int[] A)
    {
        int start = 0, max = 0;
        int currentMax = 0;
        for (int i = start; i < A.Length - 1; i++)
        {
            //if equal then start from the same point 
            if (A[i] == A[i + 1])
            {
                currentMax = 0;
                continue;
            }

            //caculating the upward movement
            if (A[i] < A[i + 1])
            {
                currentMax++;
            }
            else
            {
                //if currentmax is zero that means we have a peek directy without upward movement
                if (currentMax == 0)
                {
                    continue;
                }

                //calculating the downward movement 
                for (int j = i; j < A.Length - 1; j++)
                {
                    //if equal stop till here and assign the currentmax to the max if its greater
                    if (A[j] == A[j + 1])
                    {
                        currentMax++;
                        max = Math.Max(max, currentMax);
                        currentMax = 0;
                        i = j - 1;
                        break;
                    }

                    //calculate the downward
                    if (A[j] > A[j + 1])
                    {
                        currentMax++;
                    }
                    else
                    {
                        currentMax++;
                        max = Math.Max(max, currentMax);
                        currentMax = 0;
                        i = j - 1;
                        break;
                    }

                    //calculate the max if we reached the end of the mountain.
                    if (j == A.Length - 2)
                    {
                        currentMax++;
                        max = Math.Max(max, currentMax);
                        currentMax = 0;
                    }
                }
            }
        }

        return max;
    }
}

