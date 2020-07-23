/*
Given an array of numbers nums, in which exactly two elements appear only once and all the other elements appear exactly twice. Find the two elements that appear only once.

Example:

Input:  [1,2,1,3,2,5]
Output: [3,5]
Note:

The order of the result is not important. So in the above example, [5, 3] is also correct.
Your algorithm should run in linear runtime complexity. Could you implement it using only constant space complexity?
*/

using System.Collections.Generic;
using System.Linq;

public class SingleNumberIII
{
    public int[] SingleNumber(int[] nums)
    {
        HashSet<int> values = new HashSet<int>();
        foreach (var num in nums)
        {
            if (!values.Remove(num))
            {
                values.Add(num);
            }
        }

        return values.ToArray();
    }
}