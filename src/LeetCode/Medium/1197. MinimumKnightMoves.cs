/*
https://leetcode.com/problems/minimum-knight-moves/
In an infinite chess board with coordinates from -infinity to +infinity, you have a knight at square [0, 0].

A knight has 8 possible moves it can make, as illustrated below. Each move is two squares in a cardinal direction, then one square in an orthogonal direction.



Return the minimum number of steps needed to move the knight to the square [x, y].  It is guaranteed the answer exists.

 

Example 1:

Input: x = 2, y = 1
Output: 1
Explanation: [0, 0] → [2, 1]
Example 2:

Input: x = 5, y = 5
Output: 4
Explanation: [0, 0] → [2, 1] → [4, 2] → [3, 4] → [5, 5]
 

Constraints:

|x| + |y| <= 300

Hint #1
You can simulate the movements since the limits are low.
Hint #2
Is there a search algorithm applicable to this problem?
Hint #3
Since we want the minimum number of moves, we can use Breadth First Search.
*/

using System;
using System.Collections.Generic;

public class MinimumKnightMoves
{
    public class Pair
    {
        public int x, y;
        public Pair(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    //basic breadth first search. I did without memoization but the solution timedout. then saw this memoized solution
    public int MinKnightMoves(int x, int y)
    {
        x = Math.Abs(x);
        y = Math.Abs(y);
        Queue<Pair> queue = new Queue<Pair>();
        Pair[] directions = new Pair[] {
            new Pair(1,2),
            new Pair(2,1),
            new Pair(-1,2),
            new Pair(-2,1),
            new Pair(1,-2),
            new Pair(2,-1),
            new Pair(-1,-2),
            new Pair(-2,-1)
        };

        int steps = 0;
        HashSet<string> visited = new HashSet<string>();
        visited.Add("0,0");
        queue.Enqueue(new Pair(0, 0));
        while (queue.Count != 0)
        {
            int size = queue.Count;
            for (int i = 0; i < size; i++)
            {
                var current = queue.Dequeue();
                if (current.x == x && current.y == y)
                {
                    return steps;
                }

                for (int j = 0; j < directions.Length; j++)
                {
                    int newX = current.x + directions[j].x;
                    int newY = current.y + directions[j].y;
                    if (!visited.Contains(newX + "," + newY) && newX >= -1 && newY >= -1)
                    {
                        queue.Enqueue(new Pair(newX, newY));
                        visited.Add(newX + "," + newY);
                    }
                }
            }

            steps++;
        }

        return 0;
    }
}