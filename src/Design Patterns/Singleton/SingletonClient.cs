using System;

public class SingletonClient
{
    public static void Run()
    {
        Singleton singleton = Singleton.GetInstance();
        Console.WriteLine(singleton.GetHashCode());

        Singleton singleton1 = Singleton.GetInstance();
        Console.WriteLine(singleton1.GetHashCode());
    }
}