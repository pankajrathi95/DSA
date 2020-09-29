// The interface is implemented by many other
// subclasses that allow for many types of flying
// without effecting Animal, or Flys.

// Classes that implement new Flys interface
// subclasses can allow other classes to use
// that code eliminating code duplication

// I'm decoupling : encapsulating the concept that varies

public interface Flys
{
    string Fly();
}

//class used if the animal can fly
class ItFlys : Flys
{
    public string Fly()
    {
        return "I'm flying :)";
    }
}

//class used if the animal can't fly
class CantFly : Flys
{
    public string Fly()
    {
        return "Can't Fly :(";
    }
}