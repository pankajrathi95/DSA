using System;

namespace Prototype
{
    public class TestPrototype
    {
        public static void Run()
        {
            CloneFactory cloneFactory = new CloneFactory();
            Animal sheep = new Sheep();

            Sheep clonedSheep = (Sheep)cloneFactory.GetClone(sheep);

            Console.WriteLine(sheep.GetHashCode());
            Console.WriteLine(clonedSheep.GetHashCode());
        }
    }
}