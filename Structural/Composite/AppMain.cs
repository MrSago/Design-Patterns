using System;
using Composite;

Client client = new();

Leaf leaf = new();
Console.WriteLine("Client get simple component:");
client.ClientCode(leaf);

CompositeContainer branch1 = new();
branch1.Add(new Leaf());
branch1.Add(new Leaf());

CompositeContainer branch2 = new();
branch2.Add(new Leaf());

CompositeContainer tree = new();
tree.Add(branch1);
tree.Add(branch2);
Console.WriteLine("Client now got a composite tree:");
client.ClientCode(tree);
