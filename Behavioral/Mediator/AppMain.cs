
using System;

namespace Mediator
{
    static class AppMain
    {
        static void Main()
        {
            Component1 component1 = new();
            Component2 component2 = new();
            ConcreteMediator concreteMediator = new(component1, component2);

            Console.WriteLine("Client triggers operation A");
            component1.DoA();

            Console.Write('\n');

            Console.WriteLine("Client triggers operation D");
            component2.DoD();

            _ = Console.ReadKey(true);
        }
    }
}

