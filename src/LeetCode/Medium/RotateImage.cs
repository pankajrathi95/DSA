/*
https://leetcode.com/problems/rotate-image/
*/
public class RotateImage
{
    //To rotate the array we need to first reverse the matrix and then transpose the matrix.
    public void Rotate(int[][] matrix)
    {
        int end = matrix.Length - 1, start = 0;
        while (start < end)
        {
            for (int i = 0; i < matrix[0].Length; i++)
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
                int temp = matrix[j][i];
                matrix[j][i] = matrix[i][j];
                matrix[i][j] = temp;
            }
        }
    }
}