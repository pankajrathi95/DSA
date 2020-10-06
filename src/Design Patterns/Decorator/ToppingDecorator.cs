public abstract class ToppingDecorator : Pizza
{
    protected Pizza pizza;

    public ToppingDecorator(Pizza newPizza)
    {
        pizza = newPizza;
    }
    public virtual double GetCost()
    {
        return pizza.GetCost();
    }

    public virtual string GetDescription()
    {
        return pizza.GetDescription();
    }
}