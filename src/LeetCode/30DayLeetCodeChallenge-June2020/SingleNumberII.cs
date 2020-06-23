/*
Given a non-empty array of integers, every element appears three times except for one, which appears exactly once. Find that single one.

Note:

Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory?

Example 1:

Input: [2,2,3,2]
Output: 3
Example 2:

Input: [0,1,0,1,0,1,99]
Output: 99
*/

using System.Collections.Generic;

public class SingleNumberII
{
    public int SingleNumber(int[] nums)
    {
        Dictionary<int, int> values = new Dictionary<int, int>();

        foreach (int i in nums)
        {
            if (values.ContainsKey(i))
            {
                values[i]++;
            }
            else
            {
                values.Add(i, 1);
            }
        }

        foreach (var value in values)
        {
            if (value.Value == 1)
            {
                return value.Key;
            }
        }

        return 0;
    }
}