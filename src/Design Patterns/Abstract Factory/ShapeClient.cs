public class ShapeClient
{
    public static void Run()
    {
        //for rounded shapes
        ShapeFactoryProducer shapeFactoryProducer = new ShapeFactoryProducer();
        AbstractShapeFactory abstractShapeFactory = shapeFactoryProducer.GetFactory(true);

        Shape s1 = abstractShapeFactory.GetShape("SQUARE");
        s1.draw();
        Shape s2 = abstractShapeFactory.GetShape("RECTANGLE");
        s2.draw();

        //for normal shapes
        ShapeFactoryProducer shapeFactoryProducer1 = new ShapeFactoryProducer();
        AbstractShapeFactory abstractShapeFactory1 = shapeFactoryProducer.GetFactory(false);

        Shape s3 = abstractShapeFactory1.GetShape("SQUARE");
        s3.draw();
        Shape s4 = abstractShapeFactory1.GetShape("RECTANGLE");
        s4.draw();
    }
}