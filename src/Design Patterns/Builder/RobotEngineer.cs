public class RobotEngineer
{
    private RobotBuilder robotBuilder;

    public RobotEngineer(RobotBuilder robotBuilder)
    {
        this.robotBuilder = robotBuilder;
    }

    public Robot GetRobot()
    {
        return this.robotBuilder.GetRobot();
    }

    public void MakeRobot()
    {
        this.robotBuilder.BuildRobotArms();
        this.robotBuilder.BuildRobotHead();
        this.robotBuilder.BuildRobotLegs();
    }
}