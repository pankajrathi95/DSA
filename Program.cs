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

            QueueviaStacks queueviaStacks = new QueueviaStacks();

            queueviaStacks.Enqueue(1);
            queueviaStacks.Enqueue(2);
            queueviaStacks.Enqueue(3);
            queueviaStacks.Enqueue(4);
            queueviaStacks.Enqueue(5);
            queueviaStacks.Enqueue(6);

            Console.WriteLine(queueviaStacks.Dequeue());

            Console.WriteLine(queueviaStacks.Dequeue());
            Console.WriteLine(queueviaStacks.Dequeue());
            Console.WriteLine(queueviaStacks.Dequeue());
            Console.WriteLine(queueviaStacks.Dequeue());
            Console.WriteLine(queueviaStacks.Dequeue());
            Console.WriteLine(queueviaStacks.Dequeue());
        }
    }
}
