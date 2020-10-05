public class ShapeFactory : AbstractShapeFactory
{
    public override Shape GetShape(string shapeType)
    {
        if (shapeType.Equals("SQUARE"))
        {
            return new Square();
        }
        else if (shapeType.Equals("RECTANGLE"))
        {
            return new Rectangle();
        }
        else
        {
            return null;
        }
    }
}