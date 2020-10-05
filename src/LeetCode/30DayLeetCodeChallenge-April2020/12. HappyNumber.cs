/*
#202 - https://leetcode.com/problems/happy-number/
Write an algorithm to determine if a number is "happy".

A happy number is a number defined by the following process: Starting with any positive integer, replace the number by the sum of the squares of its digits, and repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1. Those numbers for which this process ends in 1 are happy numbers.

*/
using System.Collections.Generic;

public class HappyNumber
{
    public bool IsHappy(int n)
    {
        HashSet<int> hashSet = new HashSet<int>();
        int num = n;
        while (true)
        {
            num = SquareNumbers(num);
            if (num == 1)
            {
                return true;
            }

            if (hashSet.Contains(num))
            {
                return false;
            }
            hashSet.Add(num);
        }

    }

    private int SquareNumbers(int n)
    {
        int sum = 0;
        while (n != 0)
        {
            int i = n % 10;
            sum = sum + (i * i);
            n = n / 10;
        }
        return sum;
    }
}