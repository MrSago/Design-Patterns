﻿
using System;

namespace Bridge
{
    static class AppMain
    {
        static void Main()
        {
            Client client = new();
            Abstraction abstraction;
            ExtendedAbstraction extendedAbstraction;

            abstraction = new(new ConcreteImplementationA());
            client.ClientCode(abstraction);

            abstraction = new(new ConcreteImplementationB());
            client.ClientCode(abstraction);

            extendedAbstraction = new(new ConcreteImplementationA());
            client.ClientCode(extendedAbstraction);

            extendedAbstraction = new(new ConcreteImplementationB());
            client.ClientCode(extendedAbstraction);

            _ = Console.ReadKey(true);
        }
    }
}

