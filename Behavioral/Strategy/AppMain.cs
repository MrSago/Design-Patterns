
using System;

namespace Strategy
{
    static class AppMain
    {
        static void Main()
        {
            Context context = new();

            Console.WriteLine("Client: Strategy is set to normal sorting.");
            context.SetStrategy(new ConcreteStrategyA());
            context.DoSomeBusinessLogic();

            Console.Write('\n');

            Console.WriteLine("Client: Strategy is set to reverse sorting.");
            context.SetStrategy(new ConcreteStrategyB());
            context.DoSomeBusinessLogic();

            Console.ReadKey(true);
        }
    }
}

