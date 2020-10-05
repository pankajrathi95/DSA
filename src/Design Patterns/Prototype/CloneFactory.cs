namespace Prototype
{
    public class CloneFactory
    {
        public Animal GetClone(Animal animalSample)
        {
            return animalSample.MakeCopy();
        }
    }
}