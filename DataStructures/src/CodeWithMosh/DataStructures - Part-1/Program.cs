using System;

namespace Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            HashMapLp hashMap = new HashMapLp();

            hashMap.Put(6, "A");
            hashMap.Put(8, "BA");
            hashMap.Put(16, "PP");
            hashMap.Put(11, "AB");
            Console.ReadKey();
        }
    }
}
