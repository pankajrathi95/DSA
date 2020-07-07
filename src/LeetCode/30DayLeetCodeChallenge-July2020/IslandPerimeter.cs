/*
You are given a map in form of a two-dimensional integer grid where 1 represents land and 0 represents water.

Grid cells are connected horizontally/vertically (not diagonally). The grid is completely surrounded by water, and there is exactly one island (i.e., one or more connected land cells).

The island doesn't have "lakes" (water inside that isn't connected to the water around the island). One cell is a square with side length 1. The grid is rectangular, width and height don't exceed 100. Determine the perimeter of the island.

 

Example:

Input:
[[0,1,0,0],
 [1,1,1,0],
 [0,1,0,0],
 [1,1,0,0]]

Output: 16

Explanation: The perimeter is the 16 yellow stripes in the image below:


*/

public class IslandPerimeter
{
    int perimeter = 0;
    public int FindIslandPerimeter(int[][] grid)
    {
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == 1)
                {
                    FindThePerimeter(grid, i, j, grid.Length, grid[i].Length);
                }
            }
        }

        return perimeter;
    }

    private void FindThePerimeter(int[][] grid, int i, int j, int m, int n)
    {
        if (i < 0 || j < 0 || i >= m || j >= n || grid[i][j] == 0)
        {
            perimeter++;
            return;
        }

        if (grid[i][j] == 2)
        {
            return;
        }

        grid[i][j] = 2;

        FindThePerimeter(grid, i + 1, j, m, n);
        FindThePerimeter(grid, i - 1, j, m, n);
        FindThePerimeter(grid, i, j + 1, m, n);
        FindThePerimeter(grid, i, j - 1, m, n);
    }
}