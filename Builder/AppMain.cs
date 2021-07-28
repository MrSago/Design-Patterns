
using System;

namespace Builder
{
    static class AppMain
    {
        static void Main(string[] args)
        {
            Director director = new();
            ConcreteBuilder cb = new();
            director.Builder = cb;

            Console.WriteLine("Basic product:");
            director.BuildMinProduct();
            Console.WriteLine(cb.GetProduct().GetParts());

            Console.WriteLine("Full product:");
            director.BuildMaxProduct();
            Console.WriteLine(cb.GetProduct().GetParts());

            Console.WriteLine("Manual product:");
            cb.BuildPartA();
            cb.BuildPartC();
            Console.WriteLine(cb.GetProduct().GetParts());

            Console.ReadKey(true);
        }
    }
}

