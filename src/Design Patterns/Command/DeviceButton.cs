public class DeviceButton
{
    Command command;

    public DeviceButton(Command newCommand)
    {
        command = newCommand;
    }

    public void Press()
    {
        command.Execute();
    }

    public void PressUndo()
    {
        command.Undo();
    }
}