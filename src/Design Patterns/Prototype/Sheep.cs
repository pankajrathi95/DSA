using System;

namespace Prototype
{
    public class Sheep : Animal
    {

        public Sheep()
        {
            Console.WriteLine("Sheep is made");
        }

        public Animal MakeCopy()
        {
            Console.WriteLine("Sheep is cloned");
            Sheep sheepObject = (Sheep)this.MemberwiseClone();

            return sheepObject;
        }

        public override string ToString()
        {
            return "sheep is sheep";
        }
    }

}