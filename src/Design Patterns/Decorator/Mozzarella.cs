using System;

public class Mozzarella : ToppingDecorator
{
    public Mozzarella(Pizza newPizza) : base(newPizza)
    {
        Console.WriteLine("Adding dough");
        Console.WriteLine("Adding Mozarella");
    }
    public override double GetCost()
    {
        return pizza.GetCost() + .50;
    }

    public override string GetDescription()
    {
        return pizza.GetDescription() + ", mozzarella";
    }
}