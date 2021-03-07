/*
https://leetcode.com/problems/plus-one/
*/

using System;
using System.Collections.Generic;

public class PlusOne
{
    public int[] AddPlusOne(int[] digits)
    {
        //We need to add one. So considering carry as 1.
        int carry = 1, sum = 0;
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            sum = digits[i] + carry;
            if (sum <= 9)
            {
                digits[i] = sum;
                return digits;
            }
            else
            {
                carry = 1;
                digits[i] = sum % 10;
            }
        }

        int[] result = new int[digits.Length + 1];
        result[0] = 1;
        Array.Copy(digits, 0, result, 1, digits.Length);
        return result;
    }
}