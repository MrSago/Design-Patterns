
using System;

namespace Command
{
    public interface ICommand
    {
        void Execute();
    }

    class SimpleCommand : ICommand
    {
        private readonly string _payload;

        public SimpleCommand(string payload)
        {
            _payload = payload;
        }

        public void Execute()
        {
            Console.WriteLine($"SimpleCommand: See, I can do simple things like printing ({_payload})");
        }
    }

    class ComplexCommand : ICommand
    {
        private readonly Receiver _receiver;

        private readonly string _a;

        private readonly string _b;

        public ComplexCommand(Receiver receiver, string a, string b)
        {
            _receiver = receiver;
            _a = a;
            _b = b;
        }

        public void Execute()
        {
            Console.WriteLine("ComplexCommand: Complex stuff should be done by a receiver object.");
            _receiver.DoSomething(_a);
            _receiver.DoSomethingElse(_b);
        }
    }
}

