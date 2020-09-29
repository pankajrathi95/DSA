public class Bird : Strategy.Animal
{
    // The constructor initializes all objects
    public Bird() : base()
    {
        SetSound("Tweet");

        // We set the Flys interface polymorphically
        // This sets the behavior as a non-flying Animal

        flyingType = new ItFlys();
    }
}