/*
#1015 - https://leetcode.com/problems/smallest-integer-divisible-by-k 
Given a positive integer K, you need to find the length of the smallest positive integer N such that N is divisible by K, and N only contains the digit 1.

Return the length of N. If there is no such N, return -1.

Note: N may not fit in a 64-bit signed integer.

 

Example 1:

Input: K = 1
Output: 1
Explanation: The smallest answer is N = 1, which has length 1.
Example 2:

Input: K = 2
Output: -1
Explanation: There is no such positive integer N divisible by 2.
Example 3:

Input: K = 3
Output: 3
Explanation: The smallest answer is N = 111, which has length 3.
 

Constraints:

1 <= K <= 105
   Hide Hint #1  
11111 = 1111 * 10 + 1 We only need to store remainders modulo K.
   Hide Hint #2  
If we never get a remainder of 0, why would that happen, and how would we know that?s
*/

public class SmallestIntegerDivisiblebyK
{
    public int SmallestRepunitDivByK(int K)
    {
        if (K == 2 || K == 5)
        {
            return -1;
        }

        int res = 0;
        for (int i = 0; i < K; i++)
        {
            res = (res * 10 + 1) % K;
            if (res == 0)
            {
                return i + 1;
            }
        }

        return -1;
    }
}