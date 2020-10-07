public class TurnTvUp : Command
{
    ElectronicDevice electronicDevice;

    public TurnTvUp(ElectronicDevice newDevice)
    {
        this.electronicDevice = newDevice;
    }
    public void Execute()
    {
        electronicDevice.VolumeUp();
    }

    public void Undo()
    {
        electronicDevice.VolumeDown();
    }
}