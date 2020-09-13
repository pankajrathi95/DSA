/*
Find all possible combinations of k numbers that add up to a number n, given that only numbers from 1 to 9 can be used and each combination should be a unique set of numbers.

Note:

All numbers will be positive integers.
The solution set must not contain duplicate combinations.
Example 1:

Input: k = 3, n = 7
Output: [[1,2,4]]
Example 2:

Input: k = 3, n = 9
Output: [[1,2,6], [1,3,5], [2,3,4]]
*/

using System.Collections.Generic;
using System.Linq;

public class CombinationSumIII
{
    IList<IList<int>> result = new List<IList<int>>();
    public IList<IList<int>> CombinationSum3(int k, int n)
    {
        for (int i = 1; i <= 9; i++)
        {
            IList<int> list = new List<int>();
            list.Add(i);
            CombinationSum(i, 1, k, n, list, i);
        }

        return result;
    }

    private void CombinationSum(int index, int count, int k, int n, IList<int> list, int sum)
    {
        if (count == k && sum == n)
        {
            var tempList = new List<int>();
            tempList.AddRange(list);
            result.Add(tempList);
            return;
        }

        if (count >= k)
        {
            return;
        }

        for (int i = index + 1; i <= 9; i++)
        {
            list.Add(i);
            CombinationSum(i, count + 1, k, n, list, sum + i);
            list.RemoveAt(list.Count - 1);
        }
    }
}