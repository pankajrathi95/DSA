using System;

public class TomatoSauce : ToppingDecorator
{
    public TomatoSauce(Pizza newPizza) : base(newPizza)
    {
        Console.WriteLine("Adding sauce");
    }

    public override double GetCost()
    {
        return pizza.GetCost() + .30;
    }

    public override string GetDescription()
    {
        return pizza.GetDescription() + ", Tomato sauce";
    }
}