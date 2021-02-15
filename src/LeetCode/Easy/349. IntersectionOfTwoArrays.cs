/*
https://leetcode.com/problems/intersection-of-two-arrays/
Given two arrays, write a function to compute their intersection.

Example 1:

Input: nums1 = [1,2,2,1], nums2 = [2,2]
Output: [2]
Example 2:

Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
Output: [9,4]
Note:

Each element in the result must be unique.
The result can be in any order.
 
*/

using System.Collections.Generic;
using System.Linq;

public class IntersectionOfTwoArrays
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        HashSet<int> values = new HashSet<int>();
        foreach (var num in nums1)
        {
            if (!values.Contains(num))
            {
                values.Add(num);
            }
        }

        IList<int> result = new List<int>();
        foreach (var num in nums2)
        {
            if (values.Contains(num))
            {
                result.Add(num);
                values.Remove(num);
            }
        }

        return result.ToArray();
    }
}