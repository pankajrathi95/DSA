/*
Given a m * n matrix of ones and zeros, return how many square submatrices have all ones.

 

Example 1:

Input: matrix =
[
  [0,1,1,1],
  [1,1,1,1],
  [0,1,1,1]
]
Output: 15
Explanation: 
There are 10 squares of side 1.
There are 4 squares of side 2.
There is  1 square of side 3.
Total number of squares = 10 + 4 + 1 = 15.
Example 2:

Input: matrix = 
[
  [1,0,1],
  [1,1,0],
  [1,1,0]
]
Output: 7
Explanation: 
There are 6 squares of side 1.  
There is 1 square of side 2. 
Total number of squares = 6 + 1 = 7.
 

Constraints:

1 <= arr.length <= 300
1 <= arr[0].length <= 300
0 <= arr[i][j] <= 1
*/

using System;

public class CountSquareSubmatricesWithAllOnes
{
    //optimal solution
    public int CountSquares(int[][] matrix)
    {
        int res = 0;
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                if (matrix[i][j] == 1 && i > 0 && j > 0)
                {
                    matrix[i][j] = Math.Min(Math.Min(matrix[i - 1][j], matrix[i][j - 1]), matrix[i - 1][j - 1]) + 1;
                }
                res += matrix[i][j];
            }
        }
        return res;
    }

    //Non-Optimal Soltuion
    public int CountSquaresNonOptimal(int[][] matrix)
    {
        int res = 0;
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                if (matrix[i][j] == 1)
                {
                    res += RecursiveCount(matrix, i, j, i, j, 0);
                }
            }
        }

        return res;
    }

    private int RecursiveCount(int[][] matrix, int x_pos, int y_pos, int i, int j, int count)
    {
        //base
        if (i >= matrix.Length || j >= matrix[i].Length)
        {
            return count;
        }

        bool flag = true;
        for (int k = x_pos; k <= i; k++)
        {
            for (int l = y_pos; l <= j; l++)
            {
                if (matrix[k][l] == 0)
                {
                    flag = false;
                }
            }
        }

        if (flag == true)
        {
            count = count + 1;
        }


        return RecursiveCount(matrix, x_pos, y_pos, i + 1, j + 1, count);
    }


}