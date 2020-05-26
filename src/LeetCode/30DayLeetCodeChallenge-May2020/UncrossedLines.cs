/*
We write the integers of A and B (in the order they are given) on two separate horizontal lines.

Now, we may draw connecting lines: a straight line connecting two numbers A[i] and B[j] such that:

A[i] == B[j];
The line we draw does not intersect any other connecting (non-horizontal) line.
Note that a connecting lines cannot intersect even at the endpoints: each number can only belong to one connecting line.

Return the maximum number of connecting lines we can draw in this way.

 

Example 1:


Input: A = [1,4,2], B = [1,2,4]
Output: 2
Explanation: We can draw 2 uncrossed lines as in the diagram.
We cannot draw 3 uncrossed lines, because the line from A[1]=4 to B[2]=4 will intersect the line from A[2]=2 to B[1]=2.
Example 2:

Input: A = [2,5,1,2,5], B = [10,5,2,1,5,2]
Output: 3
Example 3:

Input: A = [1,3,7,1,7,5], B = [1,9,2,5,1]
Output: 2
 

Note:

1 <= A.Length <= 500
1 <= B.Length <= 500
1 <= A[i], B[i] <= 2000
*/

using System;

public class UncrossedLines
{
    public int MaxUncrossedLines(int[] A, int[] B)
    {
        int[][] dp = new int[A.Length][];
        for (int i = 0; i < A.Length; i++)
        {
            dp[i] = new int[B.Length];
            for (int j = 0; j < B.Length; j++)
            {
                dp[i][j] = -1;
            }
        }

        return Lcs(A, B, 0, 0, dp);
    }


    private int Lcs(int[] A, int[] B, int i, int j, int[][] dp)
    {
        if (i == A.Length || j == B.Length)
        {
            return 0;
        }
        if (dp[i][j] != -1)
        {
            return dp[i][j];
        }

        if (A[i] == B[j])
        {
            return dp[i][j] = 1 + Lcs(A, B, i + 1, j + 1, dp);
        }
        else
        {
            return dp[i][j] = Math.Max(Lcs(A, B, i + 1, j, dp), Lcs(A, B, i, j + 1, dp));
        }
    }
}