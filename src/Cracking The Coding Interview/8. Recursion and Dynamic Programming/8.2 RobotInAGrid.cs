using System;
using System.Collections.Generic;

public class RobotInAGrid
{
    public class Point
    {
        int x;
        int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public List<Point> FindThePath(bool[][] maze)
    {
        List<Point> path = new List<Point>();
        if (GetPath(maze, path, 0, 0))
        {
            return path;
        }

        return null;
    }

    private bool GetPath(bool[][] maze, List<Point> path, int row, int col)
    {
        if (row >= maze.Length || col >= maze[row].Length || !maze[row][col])
        {
            return false;
        }

        var point = new Point(row, col);

        if (IsEnd(row, col, maze) || GetPath(maze, path, row + 1, col) || GetPath(maze, path, row, col + 1))
        {
            path.Add(point);
            return true;
        }

        return false;
    }

    private bool IsEnd(int row, int col, bool[][] maze)
    {
        return row == maze.Length - 1 && col == maze[maze.Length - 1].Length - 1;
    }
}