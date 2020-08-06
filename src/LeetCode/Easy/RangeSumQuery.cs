/*
https://leetcode.com/problems/range-sum-query-immutable
*/

public class RangeSumQuery
{
    int[] nums;
    public RangeSumQuery(int[] nums)
    {
        this.nums = nums;
    }

    public int SumRange(int i, int j)
    {
        if (i > j || i >= nums.Length || j >= nums.Length)
        {
            return 0;
        }

        return nums[i] + SumRange(i + 1, j);
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(i,j);
 */