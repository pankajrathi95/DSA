using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!");

            AnimalQueue animalQueue = new AnimalQueue();
            animalQueue.Enqueue(new Cat("c1"));
            animalQueue.Enqueue(new Cat("c2"));
            animalQueue.Enqueue(new Dog("d1"));
            animalQueue.Enqueue(new Dog("d2"));
            animalQueue.Enqueue(new Cat("c3"));
            animalQueue.Enqueue(new Dog("d3"));

            Console.WriteLine(animalQueue.DequeueAny().ToString());
            Console.WriteLine(animalQueue.DequeueAny().ToString());
            Console.WriteLine(animalQueue.DequeueAny().ToString());
            Console.WriteLine(animalQueue.DequeueAny().ToString());

            Console.WriteLine(animalQueue.DequeueCat().ToString());
            Console.WriteLine(animalQueue.DequeueDog().ToString());

            Console.WriteLine(animalQueue.DequeueAny());
            Console.WriteLine(animalQueue.DequeueAny());

            Console.WriteLine(animalQueue.DequeueCat());
            Console.WriteLine(animalQueue.DequeueDog());
        }
    }
}
