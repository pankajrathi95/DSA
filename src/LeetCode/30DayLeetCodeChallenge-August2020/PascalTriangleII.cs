/*
Given a non-negative index k where k ≤ 33, return the kth index row of the Pascal's triangle.

Note that the row index starts from 0.


In Pascal's triangle, each number is the sum of the two numbers directly above it.

Example:

Input: 3
Output: [1,3,3,1]
Follow up:

Could you optimize your algorithm to use only O(k) extra space?
*/

using System.Collections.Generic;

public class PascalTriangleII
{
    public IList<int> GetRow(int rowIndex)
    {
        IList<IList<int>> result = new List<IList<int>>();
        result.Add(new List<int>(new int[] { 1 }));
        result.Add(new List<int>(new int[] { 1, 1 }));

        for (int i = 2; i <= rowIndex; i++)
        {
            IList<int> prevRow = result[i - 1];
            IList<int> currentRow = new List<int>();
            currentRow.Add(1);
            for (int j = 1; j < prevRow.Count; j++)
            {
                currentRow.Add(prevRow[j - 1] + prevRow[j]);
            }
            currentRow.Add(1);
            result.Add(currentRow);
        }

        return result[rowIndex];
    }
}