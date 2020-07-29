/*
https://leetcode.com/problems/number-of-1-bits/
*/

using System;

public class NumberOf1Bits
{
    public int HammingWeight(uint n)
    {
        string vals = Convert.ToString(n, 2);
        int count = 0;
        foreach (var val in vals)
        {
            if (val.Equals('1'))
            {
                count++;
            }
        }

        return count;
    }
}