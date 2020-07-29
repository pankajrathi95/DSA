/*
https://leetcode.com/problems/fizz-buzz/
*/

using System.Collections.Generic;

public class FizzBuzz
{
    public IList<string> FizzBuzzMethod(int n)
    {
        IList<string> result = new List<string>();
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                result.Add("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                result.Add("Fizz");
            }
            else if (i % 5 == 0)
            {
                result.Add("Buzz");
            }
            else
            {
                result.Add(i.ToString());
            }
        }

        return result;
    }
}