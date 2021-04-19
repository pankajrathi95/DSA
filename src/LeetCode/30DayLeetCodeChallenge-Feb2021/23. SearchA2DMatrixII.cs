/*
#240 - https://leetcode.com/problems/search-a-2d-matrix-ii/

Write an efficient algorithm that searches for a target value in an m x n integer matrix. The matrix has the following properties:

Integers in each row are sorted in ascending from left to right.
Integers in each column are sorted in ascending from top to bottom.
 

Example 1:


Input: matrix = [[1,4,7,11,15],[2,5,8,12,19],[3,6,9,16,22],[10,13,14,17,24],[18,21,23,26,30]], target = 5
Output: true
Example 2:


Input: matrix = [[1,4,7,11,15],[2,5,8,12,19],[3,6,9,16,22],[10,13,14,17,24],[18,21,23,26,30]], target = 20
Output: false
 

Constraints:

m == matrix.length
n == matrix[i].length
1 <= n, m <= 300
-109 <= matix[i][j] <= 109
All the integers in each row are sorted in ascending order.
All the integers in each column are sorted in ascending order.
-109 <= target <= 109
*/

public class SearchA2DMatrixII
{
    //Optimized Solution.
    public bool SearchMatrix(int[][] matrix, int target)
    {
        int row = 0, col = matrix[0].Length - 1;
        while (col >= 0 && row < matrix.Length)
        {
            if (target == matrix[row][col])
            {
                return true;
            }
            else if (target < matrix[row][col])
            {
                col--;
            }
            else
            {
                row++;
            }
        }

        return false;
    }


    //Non-optimal solution
    public bool SearchMatrix_(int[][] matrix, int target)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            if (target >= matrix[i][0] && target <= matrix[i][matrix[i].Length - 1])
            {
                if (BinarySearch(matrix[i], target))
                    return true;
            }
        }

        return false;
    }

    private bool BinarySearch(int[] matrix, int target)
    {
        int start = 0, end = matrix.Length - 1;
        while (start <= end)
        {
            int mid = (start + end) / 2;
            if (matrix[mid] == target)
            {
                return true;
            }
            else if (target > matrix[mid])
            {
                start = mid + 1;
            }
            else
            {
                end = mid - 1;
            }
        }

        return false;
    }
}