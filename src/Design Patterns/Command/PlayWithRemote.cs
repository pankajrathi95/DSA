using System.Collections.Generic;

public class PlayWithRemote
{
    public static void Run()
    {
        ElectronicDevice electronicDevice = TvRemote.GetElectronicDevice();

        TurnTvOn onCommand = new TurnTvOn(electronicDevice);
        DeviceButton onPressed = new DeviceButton(onCommand);
        onPressed.Press();

        TurnTvOff offCommand = new TurnTvOff(electronicDevice);
        onPressed = new DeviceButton(offCommand);
        onPressed.Press();

        TurnTvUp upCommand = new TurnTvUp(electronicDevice);
        onPressed = new DeviceButton(upCommand);
        onPressed.Press();
        onPressed.Press();
        onPressed.Press();
        onPressed.Press();

        Television theTv = new Television();
        Radio theRadio = new Radio();

        IList<ElectronicDevice> list = new List<ElectronicDevice>();
        list.Add(theRadio);
        list.Add(theTv);

        TurnItAllOff turnOffDevices = new TurnItAllOff(list);
        DeviceButton turnthemOff = new DeviceButton(turnOffDevices);
        turnthemOff.Press();
        turnthemOff.PressUndo();
    }
}