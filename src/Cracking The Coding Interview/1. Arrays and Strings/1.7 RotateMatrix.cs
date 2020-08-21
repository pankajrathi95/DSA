/*
Given an image represented by an N*N matrix, where each pixel in the image is 4 bytes, write a method to rotate the image by 90 degrees.
Can you do this in place?
*/

public class RotateMatrix
{
    public static int[][] RotateTheMatrix(int[][] matrix)
    {
        int start = 0, end = matrix.Length - 1;
        while (start < end)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                int temp = matrix[start][i];
                matrix[start][i] = matrix[end][i];
                matrix[end][i] = temp;
            }

            start++;
            end--;
        }

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {

                int temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
        }

        return matrix;
    }
}