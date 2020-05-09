/*
Given a positive integer num, write a function which returns True if num is a perfect square else False.

Note: Do not use any built-in library function such as sqrt.

Example 1:

Input: 16
Output: true
Example 2:

Input: 14
Output: false

*/

public class PerfectSquare
{
    public bool IsPerfectSquare(int num)
    {
        float temp = 0, sqrt = 0;
        sqrt = num / 2;
        while (temp != sqrt)
        {
            temp = sqrt;

            sqrt = (num / temp + temp) / 2;
        }

        int newVal = (int)sqrt;

        if (newVal == sqrt)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}