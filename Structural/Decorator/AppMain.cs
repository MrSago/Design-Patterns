
using System;

namespace Decorator
{
    static class AppMain
    {
        static void Main()
        {
            Client client = new();

            ConcreteComponent simple = new();
            Console.WriteLine("Simple component:");
            client.ClientCode(simple);

            ConcreteDecoratorA decoratorA = new(simple);
            ConcreteDecoratorB decoratorB = new(decoratorA);
            Console.WriteLine("Decorated components:");
            client.ClientCode(decoratorB);

            _ = Console.ReadKey(true);
        }
    }
}

