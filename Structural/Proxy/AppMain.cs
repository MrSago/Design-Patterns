
using System;

namespace Proxy
{
    static class AppMain
    {
        static void Main()
        {
            Client client = new();

            RealSubject realSubject = new();
            Console.WriteLine("Client: Executing the client code with a real subject:");
            Client.ClientCode(realSubject);

            Console.Write('\n');

            Console.WriteLine("Client: Executing the same client code with a proxy:");
            Proxy proxy = new(realSubject);
            Client.ClientCode(proxy);

            _ = Console.ReadKey(true);
        }
    }
}

