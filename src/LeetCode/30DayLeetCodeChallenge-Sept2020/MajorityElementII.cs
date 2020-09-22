/*
Given an integer array of size n, find all elements that appear more than ⌊ n/3 ⌋ times.

Note: The algorithm should run in linear time and in O(1) space.

Example 1:

Input: [3,2,3]
Output: [3]
Example 2:

Input: [1,1,1,3,3,2,2,2]
Output: [1,2]
   Hide Hint #1  
How many majority elements could it possibly have?
*/

using System.Collections.Generic;

public class MajorityElementII
{
    public IList<int> MajorityElement(int[] nums)
    {
        IList<int> result = new List<int>();
        Dictionary<int, int> values = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (values.ContainsKey(num))
            {
                values[num]++;
            }
            else
            {
                values.Add(num, 1);
            }
        }

        foreach (var kvp in values)
        {
            if (kvp.Value > nums.Length / 3)
            {
                result.Add(kvp.Key);
            }
        }

        return result;
    }
}