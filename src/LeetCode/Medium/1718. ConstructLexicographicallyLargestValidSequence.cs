/*
#1718 - https://leetcode.com/problems/construct-the-lexicographically-largest-valid-sequence/

Given an integer n, find a sequence that satisfies all of the following:

The integer 1 occurs once in the sequence.
Each integer between 2 and n occurs twice in the sequence.
For every integer i between 2 and n, the distance between the two occurrences of i is exactly i.
The distance between two numbers on the sequence, a[i] and a[j], is the absolute difference of their indices, |j - i|.

Return the lexicographically largest sequence. It is guaranteed that under the given constraints, there is always a solution.

A sequence a is lexicographically larger than a sequence b (of the same length) if in the first position where a and b differ, sequence a has a number greater than the corresponding number in b. For example, [0,1,9,0] is lexicographically larger than [0,1,5,6] because the first position they differ is at the third number, and 9 is greater than 5.

 

Example 1:

Input: n = 3
Output: [3,1,2,3,2]
Explanation: [2,3,2,1,3] is also a valid sequence, but [3,1,2,3,2] is the lexicographically largest valid sequence.
Example 2:

Input: n = 5
Output: [5,3,1,4,3,5,2,4,2]
 

Constraints:

1 <= n <= 20
*/

using System;
using System.Collections.Generic;

public class ConstructLexicographicallyLargestValidSequence
{
    bool flag = false;
    int[] result;
    public int[] ConstructDistancedSequence(int n)
    {
        int[] A = new int[2 * n - 1];
        result = new int[A.Length];
        bool[] visited = new bool[2 * n - 1];
        HashSet<int> set = new HashSet<int>();
        BackTrack(A, n, 0, set, visited);
        return result;
    }

    private void BackTrack(int[] A, int n, int start, HashSet<int> set, bool[] visited)
    {
        if (flag)
        {
            return;
        }

        if (set.Count == n)
        {
            Array.Copy(A, 0, result, 0, A.Length);
            flag = true;
            return;
        }

        if (start >= A.Length)
            return;

        for (int i = start; i < A.Length; i++)
        {
            if (visited[i])
                continue;

            for (int j = n; j > 0; j--)
            {
                if (set.Contains(j))
                    continue;

                if (j != 1 && i + j < A.Length && !visited[i + j])
                {
                    A[i] = j;
                    set.Add(j);
                    visited[i] = true;
                    A[i + j] = j;
                    visited[i + j] = true;

                    BackTrack(A, n, i + 1, set, visited);

                    A[i] = 0;
                    set.Remove(j);
                    visited[i] = false;
                    A[i + j] = 0;
                    visited[i + j] = false;
                }
                else if (j == 1)
                {
                    A[i] = j;
                    set.Add(j);
                    visited[i] = true;

                    BackTrack(A, n, i + 1, set, visited);

                    A[i] = 0;
                    set.Remove(j);
                    visited[i] = false;
                }
            }
        }
    }
}