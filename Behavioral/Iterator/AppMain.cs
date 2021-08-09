
using System;

namespace Iterator
{
    static class AppMain
    {
        static void Main()
        {
            WordsCollection collection = new();
            collection.AddItem("First");
            collection.AddItem("Second");
            collection.AddItem("Third");

            Console.WriteLine("Straight traversal:");
            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }

            collection.ReverseDirection();
            Console.WriteLine("\nReverse traversal:");
            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }

            Console.ReadKey(true);
        }
    }
}

