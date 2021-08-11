
using System;

namespace State
{
    static class AppMain
    {
        static void Main(string[] args)
        {
            Context context = new(new ConcreteStateA());
            context.Request1();
            context.Request2();
            _ = Console.ReadKey(true);
        }
    }
}

