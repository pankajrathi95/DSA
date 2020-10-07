public class TurnTvOn : Command
{
    ElectronicDevice electronicDevice;

    public TurnTvOn(ElectronicDevice newDevice)
    {
        this.electronicDevice = newDevice;
    }
    public void Execute()
    {
        electronicDevice.On();
    }

    public void Undo()
    {
        electronicDevice.Off();
    }
}