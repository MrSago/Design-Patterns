
using System;

namespace Template_Method
{
    static class AppMain
    {
        static void Main()
        {
            Console.WriteLine("Same client code can work with different subclasses:");

            Client.ClientCode(new ConcreteClass1());

            Console.Write("\n");

            Console.WriteLine("Same client code can work with different subclasses:");
            Client.ClientCode(new ConcreteClass2());

            _ = Console.ReadKey(true);
        }
    }
}

