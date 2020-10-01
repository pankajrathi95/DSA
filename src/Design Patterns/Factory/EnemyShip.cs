using System;

public abstract class EnemyShip
{
    private string name;
    private double amtDamage;

    public string GetName()
    {
        return name;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public double GetDamage()
    {
        return amtDamage;
    }

    public void SetDamage(double damage)
    {
        amtDamage = damage;
    }

    public void FollowHeroShip()
    {
        Console.WriteLine(GetName() + " is following the hero!");
    }

    public void DisplayEnemyShip()
    {
        Console.WriteLine(GetName() + " is on the screen.");
    }

    public void EnemyShipShoots()
    {
        Console.WriteLine(GetName() + "attacks and does " + GetDamage() + " damage to hero");
    }
}