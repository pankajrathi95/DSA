/*


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