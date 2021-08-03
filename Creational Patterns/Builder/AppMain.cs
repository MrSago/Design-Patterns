
using System;

namespace Builder
{
    static class AppMain
    {
        static void Main(string[] args)
        {
            Director director = new();
            ConcreteBuilder builder = new();
            director.Builder = builder;

            Console.WriteLine("Basic product:");
            director.BuildMinProduct();
            Console.WriteLine(builder.GetProduct().GetParts());

            Console.WriteLine("Full product:");
            director.BuildMaxProduct();
            Console.WriteLine(builder.GetProduct().GetParts());

            Console.WriteLine("Manual product:");
            builder.BuildPartA();
            builder.BuildPartC();
            Console.WriteLine(builder.GetProduct().GetParts());

            Console.ReadKey(true);
        }
    }
}

