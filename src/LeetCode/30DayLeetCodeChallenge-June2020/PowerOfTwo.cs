/*
Given an integer, write a function to determine if it is a power of two.

Example 1:

Input: 1
Output: true 
Explanation: 20 = 1
Example 2:

Input: 16
Output: true
Explanation: 24 = 16
Example 3:

Input: 218
Output: false
*/

using System;

public class PowerOfTwo
{
    public bool IsPowerOfTwo(int n)
    {
        for (int i = 0; i <= 32; i++)
        {
            if (Math.Pow(2, i) == n)
            {
                return true;
            }
        }

        return false;
    }
}