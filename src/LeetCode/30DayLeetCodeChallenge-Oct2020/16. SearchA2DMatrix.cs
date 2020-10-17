/*
#74 - https://leetcode.com/problems/search-a-2d-matrix/
Write an efficient algorithm that searches for a value in an m x n matrix. This matrix has the following properties:

Integers in each row are sorted from left to right.
The first integer of each row is greater than the last integer of the previous row.
 

Example 1:


Input: matrix = [[1,3,5,7],[10,11,16,20],[23,30,34,50]], target = 3
Output: true
Example 2:


Input: matrix = [[1,3,5,7],[10,11,16,20],[23,30,34,50]], target = 13
Output: false
Example 3:

Input: matrix = [], target = 0
Output: false
 

Constraints:

m == matrix.length
n == matrix[i].length
0 <= m, n <= 100
-104 <= matrix[i][j], target <= 104
*/

public class SearchA2DMatrix
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        if (matrix.Length == 0 || matrix[0].Length == 0)
        {
            return false;
        }

        for (int i = 0; i < matrix.Length; i++)
        {
            if (target != matrix[i][0] && matrix[i].Length == 1)
            {
                continue;
            }
            if (target == matrix[i][0] || target == matrix[i][matrix[i].Length - 1])
            {
                return true;
            }

            if (target > matrix[i][0] && target < matrix[i][matrix[i].Length - 1])
            {
                return BinarySearch(matrix, target, 0, matrix[i].Length - 1, i);
            }
        }

        return false;
    }

    private bool BinarySearch(int[][] matrix, int target, int start, int end, int row)
    {
        if (start > end)
        {
            return false;
        }

        int mid = (start + end) / 2;
        if (matrix[row][mid] == target)
        {
            return true;
        }

        if (matrix[row][mid] > target)
        {
            return BinarySearch(matrix, target, start, mid - 1, row);
        }
        else
        {
            return BinarySearch(matrix, target, mid + 1, end, row);
        }
    }
}