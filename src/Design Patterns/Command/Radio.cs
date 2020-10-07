using System;

public class Radio : ElectronicDevice
{
    private int volume = 0;
    public void Off()
    {
        Console.WriteLine("Radio is Off");
    }

    public void On()
    {
        Console.WriteLine("Radio is On");
    }

    public void VolumeDown()
    {
        volume--;
        Console.WriteLine("Radio volume is at " + volume);
    }

    public void VolumeUp()
    {
        volume++;
        Console.WriteLine("Radio volume is at " + volume);
    }
}