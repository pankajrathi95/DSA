using System;

public class TowersofHanoi
{
    public void Towers(int n, char from_tower, char to_tower, char aux_tower)
    {
        if (n == 1)
        {
            Console.WriteLine("Move Disk 1 from " + from_tower + " to " + to_tower);
            return;
        }

        Towers(n - 1, from_tower, aux_tower, to_tower);
        Console.WriteLine("Move Disk " + n + " from " + from_tower + " to " + to_tower);
        Towers(n - 1, aux_tower, to_tower, from_tower);
    }
}