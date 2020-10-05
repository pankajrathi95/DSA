using System;

public class TestRobot
{
    public static void Run()
    {
        RobotBuilder robotBuilder = new OldRobotBuilder();

        RobotEngineer robotEngineer = new RobotEngineer(robotBuilder);

        robotEngineer.MakeRobot();

        Robot firstRobot = robotEngineer.GetRobot();

        Console.WriteLine("Robot Build");
        Console.WriteLine(firstRobot.GetRobotArms());
        Console.WriteLine(firstRobot.GetRobotHead());
        Console.WriteLine(firstRobot.GetRobotLegs());
    }
}