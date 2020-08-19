/*
Return all non-negative integers of length N such that the absolute difference between every two consecutive digits is K.

Note that every number in the answer must not have leading zeros except for the number 0 itself. For example, 01 has one leading zero and is invalid, but 0 is valid.

You may return the answer in any order.

 

Example 1:

Input: N = 3, K = 7
Output: [181,292,707,818,929]
Explanation: Note that 070 is not a valid number, because it has leading zeroes.
Example 2:

Input: N = 2, K = 1
Output: [10,12,21,23,32,34,43,45,54,56,65,67,76,78,87,89,98]
 

Note:

1 <= N <= 9
0 <= K <= 9
*/

using System.Collections.Generic;

public class NumbersWithSameConsecutiveDifferences
{
    List<int> result = new List<int>();
    public int[] NumsSameConsecDiff(int N, int K)
    {
        if (N == 1)
        {
            return new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        }

        for (int i = 1; i <= 9; i++)
        {
            Rec(N, K, 0, i, i);
        }

        return result.ToArray();
    }

    private void Rec(int N, int K, int index, int previousDigit, int currentNumber)
    {
        if (index == N - 1)
        {
            if (currentNumber.ToString().Length == N && !result.Contains(currentNumber))
            {
                result.Add(currentNumber);
            }

            return;
        }

        int number = previousDigit + K;
        if (number < 10)
        {
            Rec(N, K, index + 1, number, currentNumber * 10 + number);
        }

        number = previousDigit - K;
        if (number >= 0)
        {
            Rec(N, K, index + 1, number, currentNumber * 10 + number);
        }
    }
}

