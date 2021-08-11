
using System;

namespace Composite
{
    static class AppMain
    {
        static void Main()
        {
            Client client = new();

            Leaf leaf = new();
            Console.WriteLine("Client get simple component:");
            client.ClientCode(leaf);

            Composite branch1 = new();
            branch1.Add(new Leaf());
            branch1.Add(new Leaf());

            Composite branch2 = new();
            branch2.Add(new Leaf());

            Composite tree = new();
            tree.Add(branch1);
            tree.Add(branch2);
            Console.WriteLine("Client now got a composite tree:");
            client.ClientCode(tree);

            _ = Console.ReadKey(true);
        }
    }
}

