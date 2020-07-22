/*
https://leetcode.com/problems/intersection-of-two-arrays-ii
*/

using System.Collections.Generic;

public class IntersectionOfTwoArraysII
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        Dictionary<int, int> values = new Dictionary<int, int>();
        foreach (var num in nums1)
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
        List<int> result = new List<int>();
        foreach (var num in nums2)
        {
            if (values.ContainsKey(num))
            {
                if (values[num] == 1)
                {
                    values.Remove(num);
                }
                else
                {
                    values[num]--;
                }

                result.Add(num);
            }
        }

        return result.ToArray();
    }
}