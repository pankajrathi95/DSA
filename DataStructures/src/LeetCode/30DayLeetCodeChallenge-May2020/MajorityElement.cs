/*

Given an array of size n, find the majority element. The majority element is the element that appears more than ⌊ n/2 ⌋ times.

You may assume that the array is non-empty and the majority element always exist in the array.

Example 1:

Input: [3,2,3]
Output: 3
Example 2:

Input: [2,2,1,1,1,2,2]
Output: 2
*/

using System.Collections.Generic;

public class MajorityElement
{
    public int FindMajorityElement(int[] nums)
    {
        Dictionary<int, int> values = new Dictionary<int, int>();
        foreach (int number in nums)
        {
            if (values.ContainsKey(number))
            {
                values[number]++;
            }
            else
            {
                values.Add(number, 1);
            }

            if (values[number] > nums.Length / 2)
            {
                return number;
            }
        }

        return 0;
    }
}