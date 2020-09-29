using System;

namespace Strategy
{
    public class AnimalPlay
    {
        public static void Run()
        {
            Animal sparky = new Dog();
            Animal tweety = new Bird();

            Console.WriteLine("Dog: " + sparky.TryToFly());
            Console.WriteLine("Bird: " + tweety.TryToFly());

            //this allows dynamic changes for flyingType

            sparky.SetFlyingAbility(new ItFlys());
            Console.WriteLine("----Flying Mode added to dog----");
            Console.WriteLine("Dog: " + sparky.TryToFly());
        }
    }
}