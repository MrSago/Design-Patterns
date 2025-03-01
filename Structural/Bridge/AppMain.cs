using System;
using Bridge;

Client client = new();
Abstraction abstraction;
ExtendedAbstraction extendedAbstraction;

abstraction = new(new ConcreteImplementationA());
client.ClientCode(abstraction);
Console.WriteLine("-----------------------------------------");

abstraction = new(new ConcreteImplementationB());
client.ClientCode(abstraction);
Console.WriteLine("-----------------------------------------");

extendedAbstraction = new(new ConcreteImplementationA());
client.ClientCode(extendedAbstraction);
Console.WriteLine("-----------------------------------------");

extendedAbstraction = new(new ConcreteImplementationB());
client.ClientCode(extendedAbstraction);
Console.WriteLine("-----------------------------------------");
