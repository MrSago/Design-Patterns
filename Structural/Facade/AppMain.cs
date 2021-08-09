
using System;

namespace Facade
{
    static class AppMain
    {
        static void Main()
        {
            Facade facade = new();
            Console.Write(facade.OperationResult());
            Console.ReadKey(true);
        }
    }
}

