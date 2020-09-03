/*
Given an array of integers, find out whether there are two distinct indices i and j in the array such that the absolute difference between nums[i] and nums[j] is at most t and the absolute difference between i and j is at most k.

Example 1:

Input: nums = [1,2,3,1], k = 3, t = 0
Output: true
Example 2:

Input: nums = [1,0,1,1], k = 1, t = 2
Output: true
Example 3:

Input: nums = [1,5,9,1,5,9], k = 2, t = 3
Output: false
*/

public class ContainsDuplicateIII
{
    public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            int end = i + k > nums.Length - 1 ? nums.Length - 1 : i + k;
            for (int j = i + 1; j <= end; j++)
            {
                if (Math.Abs((long)nums[i] - (long)nums[j]) <= t)
                {
                    return true;
                }
            }
        }

        return false;
    }
}