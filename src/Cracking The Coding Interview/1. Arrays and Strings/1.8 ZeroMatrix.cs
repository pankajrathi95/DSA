/*
Problem Statement:
Write an algorithm such that if an element in an M*N matrix is 0, its entire row and column set to 0.
*/

using System.Collections.Generic;

public class ZeroMatrix
{
    public static int[][] SetZeroMatrix(int[][] matrix)
    {
        HashSet<int> zeros = new HashSet<int>();
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                if (matrix[i][j] == 0)
                {
                    if (!zeros.Contains(i))
                    {
                        zeros.Add(i);
                    }

                    if (!zeros.Contains(j))
                    {
                        zeros.Add(j);
                    }
                }
            }
        }

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                if (zeros.Contains(i) || zeros.Contains(j))
                {
                    matrix[i][j] = 0;
                }
            }
        }

        return matrix;
    }
}