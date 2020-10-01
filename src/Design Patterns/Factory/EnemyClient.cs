using System;

public class EnemyClient
{
    public static void Run()
    {
        EnemyShipFactory enemyShipFactory = new EnemyShipFactory();
        EnemyShip enemyShip = null;

        Console.WriteLine("Enter the input string? (U/B/R)");
        string inputString = Console.ReadLine();

        enemyShip = enemyShipFactory.MakeEnemyShip(inputString);

        if (enemyShip != null)
        {
            enemyShip.DisplayEnemyShip();
            enemyShip.FollowHeroShip();
            enemyShip.EnemyShipShoots();
        }
    }
}