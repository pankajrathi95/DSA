/*
https://leetcode.com/problems/pascals-triangle/submissions/
*/

using System.Collections.Generic;

public class PascalTriangle
{
    public IList<IList<int>> Generate(int numRows)
    {
        List<IList<int>> numbers = new List<IList<int>>();
        if (numRows == 0)
        {
            return numbers;
        }

        List<int> firstRow = new List<int>();
        firstRow.Add(1);
        numbers.Add(firstRow);
        for (int i = 1; i < numRows; i++)
        {
            IList<int> prevRow = numbers[i - 1];
            List<int> row = new List<int>();

            row.Add(1);

            for (int j = 1; j < i; j++)
            {
                row.Add(prevRow[j - 1] + prevRow[j]);
            }

            row.Add(1);
            numbers.Add(row);
        }

        return numbers;
    }
}