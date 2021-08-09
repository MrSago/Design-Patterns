
using System;

namespace Decorator
{
    class Client
    {
        public void ClientCode(IComponent component)
        {
            Console.WriteLine($"Result: {component.Operation()}\n");
        }
    }
}

