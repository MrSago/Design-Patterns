using System;

namespace Command;

public interface ICommand
{
    void Execute();
}

class SimpleCommand(string payload) : ICommand
{
    private readonly string _payload = payload;

    public void Execute()
    {
        Console.WriteLine($"SimpleCommand: See, I can do simple things like printing ({_payload})");
    }
}

class ComplexCommand(Receiver receiver, string a, string b) : ICommand
{
    private readonly Receiver _receiver = receiver;

    private readonly string _a = a;

    private readonly string _b = b;

    public void Execute()
    {
        Console.WriteLine("ComplexCommand: Complex stuff should be done by a receiver object.");
        _receiver.DoSomething(_a);
        _receiver.DoSomethingElse(_b);
    }
}
