using System;
namespace Strategy
{
    public class Animal
    {

        private string name;
        private double height;
        private int weight;
        private string favFood;
        private double speed;
        private string sound;

        // Instead of using an interface in a traditional way
        // we use an instance variable that is a subclass
        // of the Flys interface.

        // Animal doesn't care what flyingType does, it just
        // knows the behavior is available to its subclasses

        // This is known as Composition : Instead of inheriting
        // an ability through inheritance the class is composed
        // with Objects with the right ability

        // Composition allows you to change the capabilities of 
        // objects at run time!

        public Flys flyingType;

        public void SetName(string newName) { name = newName; }
        public string GetName() { return name; }

        public void SetHeight(double newHeight) { height = newHeight; }
        public double GetHeight() { return height; }

        public void SetWeight(int newWeight)
        {
            if (newWeight > 0)
            {
                weight = newWeight;
            }
            else
            {
                Console.WriteLine("Weight must be bigger than 0");
            }
        }
        public double GetWeight() { return weight; }

        public void SetFavFood(string newFavFood) { favFood = newFavFood; }
        public string GetFavFood() { return favFood; }

        public void SetSpeed(double newSpeed) { speed = newSpeed; }
        public double GetSpeed() { return speed; }

        public void SetSound(string newSound) { sound = newSound; }
        public string GetSound() { return sound; }

        /* BAD
        * You don't want to add methods to the super class.
        * You need to separate what is different between subclasses
        * and the super class
        public void fly(){

            System.out.println("I'm flying");

        }
        */

        // Animal pushes off the responsibility for flying to flyingType

        public string TryToFly()
        {

            return flyingType.Fly();

        }

        // If you want to be able to change the flyingType dynamically
        // add the following method

        public void SetFlyingAbility(Flys newFlyType)
        {

            flyingType = newFlyType;

        }

    }
}

