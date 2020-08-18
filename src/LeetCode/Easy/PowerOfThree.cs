/*
https://leetcode.com/problems/power-of-three
*/

public class PowerOfThree
{
    public bool IsPowerOfThree(int n)
    {
        while (n > 1)
        {
            if (n % 3 != 0)
            {
                return false;
            }

            n /= 3;
        }

        return n == 1;
    }
}