
using System;
using System.Collections.Generic;

namespace Visitor
{
    static class AppMain
    {
        static void Main()
        {
            List<IComponent> components =
            [
                new ConcreteComponentA(),
                new ConcreteComponentB()
            ];

            Console.WriteLine("The client code works with all visitors via the base Visitor interface:");
            ConcreteVisitor1 visitor1 = new();
            Client.ClientCode(components, visitor1);

            Console.Write('\n');

            Console.WriteLine("It allows the same client code to work with different types of visitors:");
            ConcreteVisitor2 visitor2 = new();
            Client.ClientCode(components, visitor2);

            _ = Console.ReadKey(true);
        }
    }
}

