using System;
using System.Collections.Generic;

public class AnimalQueue
{
    LinkedList<Dog> dogs = new LinkedList<Dog>();
    LinkedList<Cat> cats = new LinkedList<Cat>();
    int order = 0;

    public void Enqueue(Animal a)
    {
        a.SetOrder(order++);
        if (a is Cat)
        {
            cats.AddLast((Cat)a);
        }
        else
        {
            dogs.AddLast((Dog)a);
        }
    }

    public Animal DequeueAny()
    {
        if (cats.Count == 0 && dogs.Count == 0)
        {
            Console.WriteLine("No animal found!");
            return null;
        }
        else if (cats.Count == 0)
        {
            dogs.RemoveFirst();
            return dogs.First.Value;
        }
        else if (dogs.Count == 0)
        {
            cats.RemoveFirst();
            return cats.First.Value;
        }

        Animal cat = cats.First.Value;
        Animal dog = dogs.First.Value;
        if (dog.IsOlderThan(cat))
        {
            dogs.RemoveFirst();
            return dog;
        }
        else
        {
            cats.RemoveFirst();
            return cat;
        }
    }

    public Animal DequeueCat()
    {
        if (cats.Count == 0)
        {
            Console.WriteLine("No Cats found");
            return null;
        }

        Animal cat = cats.First.Value;
        cats.RemoveFirst();
        return cat;
    }

    public Animal DequeueDog()
    {
        if (dogs.Count == 0)
        {
            Console.WriteLine("No Dogs found");
            return null;
        }

        Animal dog = dogs.First.Value;
        dogs.RemoveFirst();
        return dog;
    }
}

public abstract class Animal
{
    private int order;
    protected string name;
    public Animal(string n)
    {
        name = n;
    }

    public void SetOrder(int order)
    {
        this.order = order;
    }

    public int GetOrder()
    {
        return order;
    }

    public bool IsOlderThan(Animal a)
    {
        return order < a.GetOrder();
    }

    public override string ToString()
    {
        return name;
    }
}

public class Dog : Animal
{
    public Dog(string n) : base(n)
    {
    }
}

public class Cat : Animal
{
    public Cat(string n) : base(n)
    {
    }
}
