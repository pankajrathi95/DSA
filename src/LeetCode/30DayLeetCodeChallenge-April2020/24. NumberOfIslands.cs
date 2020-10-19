/*
#200 - https://leetcode.com/problems/number-of-islands
Given a 2d grid map of '1's (land) and '0's (water), count the number of islands. An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. You may assume all four edges of the grid are all surrounded by water.

Example 1:

Input:
11110
11010
11000
00000
Output: 1

Example 2:

Input:
11000
11000
00100
00011
Output: 3
*/

class NumberOfIslands
{
    public int NumIslands(char[][] grid)
    {
        int count = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == '1')
                {
                    count++;
                    CoverIslands(grid, i, j);
                }
            }
        }

        return count;
    }

    private void CoverIslands(char[][] grid, int i, int j)
    {
        if (i < 0 || j < 0 || i >= grid.Length || j >= grid[i].Length || grid[i][j] == '0')
        {
            return;
        }

        grid[i][j] = '0';
        CoverIslands(grid, i + 1, j);
        CoverIslands(grid, i, j + 1);
        CoverIslands(grid, i - 1, j);
        CoverIslands(grid, i, j - 1);
    }
}