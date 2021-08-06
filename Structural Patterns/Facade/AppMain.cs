
using System;

namespace Facade
{
    static class AppMain
    {
        static void Main(string[] args)
        {
            Facade facade = new();
            Console.Write(facade.OperationResult());
            Console.ReadKey(true);
        }
    }
}

