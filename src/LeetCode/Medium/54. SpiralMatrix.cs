/*
https://leetcode.com/problems/spiral-matrix/
Given an m x n matrix, return all elements of the matrix in spiral order.

 

Example 1:


Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
Output: [1,2,3,6,9,8,7,4,5]
Example 2:


Input: matrix = [[1,2,3,4],[5,6,7,8],[9,10,11,12]]
Output: [1,2,3,4,8,12,11,10,9,5,6,7]
 

Constraints:

m == matrix.length
n == matrix[i].length
1 <= m, n <= 10
-100 <= matrix[i][j] <= 100
*/

using System.Collections.Generic;

public class SpiralMatrix
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        IList<int> result = new List<int>();
        if (matrix == null || matrix.Length == 0)
        {
            return result;
        }

        int top = 0, bottom = matrix.Length - 1;
        int left = 0, right = matrix[0].Length - 1;
        int dir = 0;

        while (left <= right && top <= bottom)
        {
            if (dir == 0)
            {
                for (int i = left; i <= right; i++)
                {
                    result.Add(matrix[top][i]);
                }

                top++;
            }
            else if (dir == 1)
            {
                for (int i = top; i <= bottom; i++)
                {
                    result.Add(matrix[i][right]);
                }

                right--;
            }
            else if (dir == 2)
            {
                for (int i = right; i >= left; i--)
                {
                    result.Add(matrix[bottom][i]);
                }

                bottom--;
            }
            else if (dir == 3)
            {
                for (int i = bottom; i >= top; i--)
                {
                    result.Add(matrix[i][left]);
                }

                left++;
            }

            dir = (dir + 1) % 4;
        }

        return result;
    }
}