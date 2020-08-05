/*
https://leetcode.com/problems/string-to-integer-atoi/
*/

using System;

public class Atoi
{
    public int MyAtoi(string str)
    {
        str = str.Trim();

        if (str.Length == 0 || str == null)
        {
            return 0;
        }

        int start = 0, sign = 1, len = str.Length;
        long sum = 0;
        char firstChar = str[start];
        if (firstChar == '-')
        {
            sign = -1;
            start++;
        }
        else if (firstChar == '+')
        {
            start++;
        }

        for (int i = start; i < len; i++)
        {
            if (!Char.IsDigit(str[i]))
            {
                return (int)sum * sign;
            }

            sum = sum * 10 + str[i] - '0';

            if (sign == 1 && sum > int.MaxValue)
            {
                return int.MaxValue;
            }
            else if (sign == -1 && (-1) * sum < int.MinValue)
            {
                return int.MinValue;
            }
        }

        return (int)sum * sign;
    }
}