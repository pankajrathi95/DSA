public class OldRobotBuilder : RobotBuilder
{
    private Robot robot;
    public OldRobotBuilder()
    {
        this.robot = new Robot();
    }
    public void BuildRobotArms()
    {
        robot.SetRobotArms("Tin Arms");
    }

    public void BuildRobotHead()
    {
        robot.SetRobotHead("Tin Head");
    }

    public void BuildRobotLegs()
    {
        robot.SetRobotLegs("Tin Legs");
    }

    public Robot GetRobot()
    {
        return robot;
    }
}