/*
#526 - https://leetcode.com/problems/beautiful-arrangement/
Suppose you have n integers from 1 to n. We define a beautiful arrangement as an array that is constructed by these n numbers successfully if one of the following is true for the ith position (1 <= i <= n) in this array:

The number at the ith position is divisible by i.
i is divisible by the number at the ith position.
Given an integer n, return the number of the beautiful arrangements that you can construct.

 

Example 1:

Input: n = 2
Output: 2
Explanation: 
The first beautiful arrangement is [1, 2]:
Number at the 1st position (i=1) is 1, and 1 is divisible by i (i=1).
Number at the 2nd position (i=2) is 2, and 2 is divisible by i (i=2).
The second beautiful arrangement is [2, 1]:
Number at the 1st position (i=1) is 2, and 2 is divisible by i (i=1).
Number at the 2nd position (i=2) is 1, and i (i=2) is divisible by 1.
Example 2:

Input: n = 1
Output: 1
 

Constraints:

1 <= n <= 15
*/

public class BeautifulArrangement
{
    int count = 0;
    public int CountArrangement(int n)
    {
        BackTrack(new int[n + 1], 1, n);
        return count;
    }

    private void BackTrack(int[] used, int current, int n)
    {
        if (current > n)
        {
            count++;
            return;
        }

        for (int i = 1; i <= n; i++)
        {
            if (used[i] == 0 && (current % i == 0 || i % current == 0))
            {
                used[i] = 1;
                BackTrack(used, current + 1, n);
                used[i] = 0;
            }
        }
    }
}