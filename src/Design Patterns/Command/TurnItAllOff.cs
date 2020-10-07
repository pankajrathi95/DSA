using System.Collections.Generic;

public class TurnItAllOff : Command
{
    IList<ElectronicDevice> theDevices;
    public TurnItAllOff(IList<ElectronicDevice> theDevices)
    {
        this.theDevices = theDevices;
    }
    public void Execute()
    {
        foreach (var device in theDevices)
        {
            device.Off();
        }
    }

    public void Undo()
    {
        foreach (var device in theDevices)
        {
            device.On();
        }
    }
}