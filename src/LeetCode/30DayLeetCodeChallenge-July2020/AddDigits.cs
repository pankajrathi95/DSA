/*
Given a non-negative integer num, repeatedly add all its digits until the result has only one digit.

Example:

Input: 38
Output: 2 
Explanation: The process is like: 3 + 8 = 11, 1 + 1 = 2. 
             Since 2 has only one digit, return it.
Follow up:
Could you do it without any loop/recursion in O(1) runtime?
*/

using System;

public class AddDigits
{
    public int AddTheDigits(int num)
    {
        int sum = 0;
        String s = num.ToString();
        for (int i = 0; i < s.Length; i++)
        {
            sum += (s[i] - '0');
        }


        if (sum >= 10)
        {
            return AddDigits(sum);
        }

        return sum;
    }
}