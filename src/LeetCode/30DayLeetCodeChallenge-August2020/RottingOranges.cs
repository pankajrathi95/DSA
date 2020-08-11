/*
In a given grid, each cell can have one of three values:

the value 0 representing an empty cell;
the value 1 representing a fresh orange;
the value 2 representing a rotten orange.
Every minute, any fresh orange that is adjacent (4-directionally) to a rotten orange becomes rotten.

Return the minimum number of minutes that must elapse until no cell has a fresh orange.  If this is impossible, return -1 instead.

 

Example 1:



Input: [[2,1,1],[1,1,0],[0,1,1]]
Output: 4
Example 2:

Input: [[2,1,1],[0,1,1],[1,0,1]]
Output: -1
Explanation:  The orange in the bottom left corner (row 2, column 0) is never rotten, because rotting only happens 4-directionally.
Example 3:

Input: [[0,2]]
Output: 0
Explanation:  Since there are already no fresh oranges at minute 0, the answer is just 0.
 

Note:

1 <= grid.length <= 10
1 <= grid[0].length <= 10
grid[i][j] is only 0, 1, or 2.
*/

using System.Collections.Generic;

public class RottingOranges
{
    public class Orange
    {
        public int x;
        public int y;
        public Orange(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public int OrangesRotting(int[][] grid)
    {
        Queue<Orange> queue = new Queue<Orange>();
        int freshOranges = 0, minutes = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == 1)
                {
                    freshOranges++;
                }

                if (grid[i][j] == 2)
                {
                    queue.Enqueue(new Orange(i, j));
                }
            }
        }

        if (freshOranges == 0)
        {
            return 0;
        }

        while (queue.Count != 0)
        {
            int size = queue.Count;
            for (int i = 0; i < size; i++)
            {
                Orange currentOrange = queue.Dequeue();
                if (currentOrange.x < grid.Length - 1 && grid[currentOrange.x + 1][currentOrange.y] == 1)
                {
                    freshOranges--;
                    grid[currentOrange.x + 1][currentOrange.y] = 2;
                    queue.Enqueue(new Orange(currentOrange.x + 1, currentOrange.y));
                }

                if (currentOrange.x > 0 && grid[currentOrange.x - 1][currentOrange.y] == 1)
                {
                    freshOranges--;
                    grid[currentOrange.x - 1][currentOrange.y] = 2;
                    queue.Enqueue(new Orange(currentOrange.x - 1, currentOrange.y));
                }

                if (currentOrange.y + 1 <= grid[0].Length - 1 && grid[currentOrange.x][currentOrange.y + 1] == 1)
                {
                    freshOranges--;
                    grid[currentOrange.x][currentOrange.y + 1] = 2;
                    queue.Enqueue(new Orange(currentOrange.x, currentOrange.y + 1));
                }

                if (currentOrange.y > 0 && grid[currentOrange.x][currentOrange.y - 1] == 1)
                {
                    freshOranges--;
                    grid[currentOrange.x][currentOrange.y - 1] = 2;
                    queue.Enqueue(new Orange(currentOrange.x, currentOrange.y - 1));
                }
            }

            minutes++;
        }

        if (freshOranges != 0)
        {
            return -1;
        }

        return minutes - 1;
    }
}