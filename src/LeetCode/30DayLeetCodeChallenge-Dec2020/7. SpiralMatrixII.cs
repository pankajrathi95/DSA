/*
#59 - https://leetcode.com/problems/spiral-matrix-ii/
Given a positive integer n, generate an n x n matrix filled with elements from 1 to n2 in spiral order.

 

Example 1:


Input: n = 3
Output: [[1,2,3],[8,9,4],[7,6,5]]
Example 2:

Input: n = 1
Output: [[1]]
 

Constraints:

1 <= n <= 20
*/

public class SpiralMatrixII
{
    public int[][] GenerateMatrix(int n)
    {
        int[][] result = new int[n][];
        for (int i = 0; i < n; i++)
        {
            result[i] = new int[n];
        }

        int top = 0, bottom = n - 1, left = 0, right = n - 1, dir = 0;
        int counter = 1;
        while (left <= right && top <= bottom)
        {
            if (dir == 0)
            {
                for (int i = left; i <= right; i++)
                {
                    result[top][i] = counter++;
                }

                top++;
            }
            else if (dir == 1)
            {
                for (int i = top; i <= bottom; i++)
                {
                    result[i][right] = counter++;
                }

                right--;
            }
            else if (dir == 2)
            {
                for (int i = right; i >= left; i--)
                {
                    result[bottom][i] = counter++;
                }

                bottom--;
            }
            else if (dir == 3)
            {
                for (int i = bottom; i >= top; i--)
                {
                    result[i][left] = counter++;
                }

                left++;
            }

            dir = (dir + 1) % 4;
        }


        return result;
    }
}