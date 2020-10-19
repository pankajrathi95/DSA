
/*
#33 - https://leetcode.com/problems/search-in-rotated-sorted-array/
Suppose an array sorted in ascending order is rotated at some pivot unknown to you beforehand.

(i.e., [0,1,2,4,5,6,7] might become [4,5,6,7,0,1,2]).

You are given a target value to search. If found in the array return its index, otherwise return -1.

You may assume no duplicate exists in the array.

Your algorithm's runtime complexity must be in the order of O(log n).

Example 1:

Input: nums = [4,5,6,7,0,1,2], target = 0
Output: 4
Example 2:

Input: nums = [4,5,6,7,0,1,2], target = 3
Output: -1
*/
public class SearchInRotatedSortedArray
{
    public int Search(int[] nums, int target)
    {
        int mid = (0 + nums.Length) / 2;
        return BinarySearch(nums, 0, nums.Length - 1, target);
    }

    public int BinarySearch(int[] nums, int start, int end, int target)
    {
        if (end >= start)
        {
            int mid = (start + end) / 2;

            if (nums[mid] == target)
            {
                return mid;
            }

            else if (nums[start] <= nums[mid])
            {
                if (target >= nums[start] && target <= nums[mid])
                {
                    return BinarySearch(nums, start, mid - 1, target);
                }
                else
                {
                    return BinarySearch(nums, mid + 1, end, target);
                }
            }
            else
            {
                if (target >= nums[mid] && target <= nums[end])
                {
                    return BinarySearch(nums, mid + 1, end, target);
                }
                else
                {
                    return BinarySearch(nums, start, mid - 1, target);
                }
            }
        }

        return -1;
    }
}