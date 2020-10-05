public class Robot : RobotPlan
{
    private string robotArms;
    private string robotHead;
    private string robotLegs;

    public void SetRobotArms(string arms)
    {
        robotArms = arms;
    }

    public void SetRobotHead(string head)
    {
        robotHead = head;
    }

    public void SetRobotLegs(string legs)
    {
        robotLegs = legs;
    }

    public string GetRobotArms()
    {
        return robotArms;
    }

    public string GetRobotLegs()
    {
        return robotLegs;
    }

    public string GetRobotHead()
    {
        return robotHead;
    }
}