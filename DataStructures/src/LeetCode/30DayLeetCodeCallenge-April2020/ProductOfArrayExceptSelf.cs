/*
Given an array nums of n integers where n > 1,  return an array output such that output[i] is equal to the product of all the elements of nums except nums[i].

Example:

Input:  [1,2,3,4]
Output: [24,12,8,6]
Constraint: It's guaranteed that the product of the elements of any prefix or suffix of the array (including the whole array) fits in a 32 bit integer.

Note: Please solve it without division and in O(n).

Follow up:
Could you solve it with constant space complexity? (The output array does not count as extra space for the purpose of space complexity analysis.)

*/

public class ProductOfArrayExceptSelf
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] left = new int[nums.Length];
        int[] right = new int[nums.Length];

        left[0] = 1;
        right[right.Length - 1] = 1;

        for (int i = 0; i < left.Length - 1; i++)
        {
            left[i + 1] = left[i] * nums[i];
        }

        for (int i = right.Length - 1; i > 0; i--)
        {
            right[i - 1] = right[i] * nums[i];
        }

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = left[i] * right[i];
        }

        return nums;
    }
}