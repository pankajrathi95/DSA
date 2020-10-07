public class TurnTvOff : Command
{
    ElectronicDevice electronicDevice;

    public TurnTvOff(ElectronicDevice newDevice)
    {
        this.electronicDevice = newDevice;
    }
    public void Execute()
    {
        electronicDevice.Off();
    }

    public void Undo()
    {
        electronicDevice.On();
    }
}