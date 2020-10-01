// This is a factory thats only job is creating ships
// By encapsulating ship creation, we only have one
// place to make modifications
public class EnemyShipFactory
{
    public EnemyShip MakeEnemyShip(string enemyType)
    {
        if (enemyType.Equals("U"))
        {
            return new UFOEnemyShip();
        }
        else if (enemyType.Equals("B"))
        {
            return new BigUFOEnemyShip();
        }
        else if (enemyType.Equals("R"))
        {
            return new RocketEnemyShip();
        }
        else
        {
            return null;
        }
    }
}