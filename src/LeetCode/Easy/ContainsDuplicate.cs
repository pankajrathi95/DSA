/*
https://leetcode.com/problems/contains-duplicate
*/

using System.Collections.Generic;

public class ContainsDuplicate
{
    public bool ContainsDuplicates(int[] nums)
    {
        HashSet<int> values = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (values.Contains(nums[i]))
            {
                return true;
            }
            else
            {
                values.Add(nums[i]);
            }
        }

        return false;
    }
}