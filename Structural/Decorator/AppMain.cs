using System;
using Decorator;

Client client = new();
ConcreteComponent simple = new();

Console.WriteLine("Simple component:");
client.ClientCode(simple);

ConcreteDecoratorA decoratorA = new(simple);
ConcreteDecoratorB decoratorB = new(decoratorA);
ConcreteDecoratorB decoratorB2 = new(decoratorB);

Console.WriteLine("Decorated components:");
client.ClientCode(decoratorB2);
