using System;

public class Television : ElectronicDevice
{
    private int volume = 0;
    public void Off()
    {
        Console.WriteLine("TV is Off");
    }

    public void On()
    {
        Console.WriteLine("TV is On");
    }

    public void VolumeDown()
    {
        volume--;
        Console.WriteLine("TV volume is at " + volume);
    }

    public void VolumeUp()
    {
        volume++;
        Console.WriteLine("TV volume is at " + volume);
    }
}