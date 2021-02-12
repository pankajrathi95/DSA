/*
#228 - https://leetcode.com/problems/summary-ranges/

You are given a sorted unique integer array nums.

Return the smallest sorted list of ranges that cover all the numbers in the array exactly. That is, each element of nums is covered by exactly one of the ranges, and there is no integer x such that x is in one of the ranges but not in nums.

Each range [a,b] in the list should be output as:

"a->b" if a != b
"a" if a == b
 

Example 1:

Input: nums = [0,1,2,4,5,7]
Output: ["0->2","4->5","7"]
Explanation: The ranges are:
[0,2] --> "0->2"
[4,5] --> "4->5"
[7,7] --> "7"
Example 2:

Input: nums = [0,2,3,4,6,8,9]
Output: ["0","2->4","6","8->9"]
Explanation: The ranges are:
[0,0] --> "0"
[2,4] --> "2->4"
[6,6] --> "6"
[8,9] --> "8->9"
Example 3:

Input: nums = []
Output: []
Example 4:

Input: nums = [-1]
Output: ["-1"]
Example 5:

Input: nums = [0]
Output: ["0"]
 

Constraints:

0 <= nums.length <= 20
-231 <= nums[i] <= 231 - 1
All the values of nums are unique.
*/

using System.Collections.Generic;

public class SummrayRanges
{
    public IList<string> SummaryRanges(int[] nums)
    {
        IList<string> result = new List<string>();
        if (nums.Length == 0)
        {
            return result;
        }

        int start = 0;
        int end = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[end] + 1 == nums[i])
            {
                end++;
            }
            else
            {
                if (start == end)
                {
                    result.Add("" + nums[start]);
                }
                else
                {
                    result.Add(nums[start] + "->" + nums[end]);
                }

                end++;
                start = end;
            }
        }

        if (start == end)
        {
            result.Add("" + nums[start]);
        }
        else
        {
            result.Add(nums[start] + "->" + nums[end]);
        }

        return result;
    }

    public IList<string> SummaryRangess(int[] nums)
    {
        IList<string> result = new List<string>();
        if (nums.Length == 0)
        {
            return result;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            int num = nums[i];
            while (i + 1 < nums.Length && nums[i] + 1 == nums[i + 1])
            {
                i++;
            }

            if (num == nums[i])
            {
                result.Add(num.ToString());
            }
            else
            {
                result.Add(num + "->" + nums[i]);
            }
        }

        return result;
    }
}