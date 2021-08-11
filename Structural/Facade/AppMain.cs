
using System;

namespace Facade
{
    static class AppMain
    {
        static void Main()
        {
            Facade facade = new();
            Console.Write(facade.OperationResult());
            _ = Console.ReadKey(true);
        }
    }
}

