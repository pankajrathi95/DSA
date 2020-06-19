/*
https://leetcode.com/problems/sqrtx/
*/

public class Sqrts
{
    public int MySqrt(int x)
    {
        long start = 0, end = x;

        while (start + 1 < end)
        {
            long mid = start + (end - start) / 2;

            if (mid * mid == x)
            {
                return (int)mid;
            }
            else if (mid * mid < x)
            {
                start = mid;
            }
            else
            {
                end = mid;
            }
        }

        if (end * end == x)
        {
            return (int)end;
        }
        else
        {
            return (int)start;
        }
    }
}