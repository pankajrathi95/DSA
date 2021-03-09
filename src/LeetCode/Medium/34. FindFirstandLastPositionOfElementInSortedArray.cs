/*
https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/
Given an array of integers nums sorted in ascending order, find the starting and ending position of a given target value.

If target is not found in the array, return [-1, -1].

Follow up: Could you write an algorithm with O(log n) runtime complexity?

 

Example 1:

Input: nums = [5,7,7,8,8,10], target = 8
Output: [3,4]
Example 2:

Input: nums = [5,7,7,8,8,10], target = 6
Output: [-1,-1]
Example 3:

Input: nums = [], target = 0
Output: [-1,-1]
 

Constraints:

0 <= nums.length <= 105
-109 <= nums[i] <= 109
nums is a non-decreasing array.
-109 <= target <= 109
*/

public class FindFirstandLastPositionOfElementInSortedArray
{
    public int[] SearchRange(int[] nums, int target)
    {
        int[] result = { -1, -1 };

        int leftIndex = BinarySearch(nums, target, true);
        if (leftIndex == nums.Length || nums[leftIndex] != target)
        {
            return result;
        }

        result[0] = leftIndex;
        result[1] = BinarySearch(nums, target, false) - 1;
        return result;
    }

    private int BinarySearch(int[] nums, int target, bool left)
    {
        int low = 0, high = nums.Length;
        while (low < high)
        {
            int mid = low + (high - low) / 2;
            if (nums[mid] > target || (left && nums[mid] == target))
            {
                high = mid;
            }
            else
            {
                low = mid + 1;
            }
        }

        return low;
    }
}