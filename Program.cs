using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace DataStructures
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!");
            var watch = new Stopwatch();
            watch.Start();
            var robot = new RobotInAGrid();
            bool[][] maze = new bool[4][];
            maze[0] = new bool[] { false, true, true, true };
            maze[1] = new bool[] { false, true, true, true };
            maze[2] = new bool[] { true, true, true, false };
            maze[3] = new bool[] { true, false, true, true };
            robot.FindThePath(maze);
            watch.Stop();
            Console.WriteLine("Time Taken: " + watch.ElapsedMilliseconds + " ms");
        }
    }
}
