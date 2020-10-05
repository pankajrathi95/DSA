public class RoundedShapeFactory : AbstractShapeFactory
{
    public override Shape GetShape(string shapeType)
    {
        if (shapeType.Equals("SQUARE"))
        {
            return new RoundedSquare();
        }
        else if (shapeType.Equals("RECTANGLE"))
        {
            return new RoundedRectangle();
        }
        else
        {
            return null;
        }
    }
}