public class ShapeFactoryProducer
{
    public AbstractShapeFactory GetFactory(bool rounded)
    {
        if (rounded)
        {
            return new RoundedShapeFactory();
        }
        else
        {
            return new ShapeFactory();
        }
    }
}