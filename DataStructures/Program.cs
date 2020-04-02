using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            HappyNumber happy = new HappyNumber();
            Console.WriteLine(happy.IsHappy(19));

        }
    }
}
