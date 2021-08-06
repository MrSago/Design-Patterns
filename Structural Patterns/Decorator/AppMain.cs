
using System;

namespace Decorator
{
    static class AppMain
    {
        static void Main(string[] args)
        {
            Client client = new();

            ConcreteComponent simple = new();
            Console.WriteLine("Simple component:");
            client.ClientCode(simple);

            ConcreteDecoratorA decoratorA = new(simple);
            ConcreteDecoratorB decoratorB = new(decoratorA);
            Console.WriteLine("Decorated components:");
            client.ClientCode(decoratorB);

            Console.ReadKey(true);
        }
    }
}

