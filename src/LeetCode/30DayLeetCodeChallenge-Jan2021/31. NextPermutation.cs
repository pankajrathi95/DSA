/*
#31 - https://leetcode.com/problems/next-permutation/

Implement next permutation, which rearranges numbers into the lexicographically next greater permutation of numbers.

If such an arrangement is not possible, it must rearrange it as the lowest possible order (i.e., sorted in ascending order).

The replacement must be in place and use only constant extra memory.

 

Example 1:

Input: nums = [1,2,3]
Output: [1,3,2]
Example 2:

Input: nums = [3,2,1]
Output: [1,2,3]
Example 3:

Input: nums = [1,1,5]
Output: [1,5,1]
Example 4:

Input: nums = [1]
Output: [1]
 

Constraints:

1 <= nums.length <= 100
0 <= nums[i] <= 100
*/

public class NextPermutation
{
    public void FindNextPermutation(int[] nums)
    {
        //first get which index from the last element the number starts to decrease
        int index = nums.Length - 2;
        while (index >= 0 && nums[index] >= nums[index + 1])
        {
            index--;
        }

        //if there is no index then just reverse the list.
        if (index == -1)
        {
            Reverse(nums, 0, nums.Length - 1);
            return;
        }

        //from the last number till index. Swap whever you see any number greater than index.
        for (int i = nums.Length - 1; i > index; i--)
        {
            if (nums[i] > nums[index])
            {
                Swap(nums, i, index);
                break;
            }
        }

        //Reverse the right part of list i.e., from (index + 1) th element
        Reverse(nums, index + 1, nums.Length - 1);
    }

    private void Swap(int[] nums, int x, int y)
    {
        int temp = nums[x];
        nums[x] = nums[y];
        nums[y] = temp;
    }

    private void Reverse(int[] nums, int start, int end)
    {
        while (start < end)
        {
            Swap(nums, start++, end--);
        }
    }
}