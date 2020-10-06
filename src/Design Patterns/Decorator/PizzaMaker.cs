using System;

public class PizzaMaker
{
    public static void Run()
    {
        Pizza basicPizza = new TomatoSauce(new Mozzarella(new PlainPizza()));

        Console.WriteLine(basicPizza.GetDescription());
        Console.WriteLine(basicPizza.GetCost());
    }
}