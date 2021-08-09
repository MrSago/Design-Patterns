
using System;

namespace Command
{
    static class AppMain
    {
        static void Main(string[] args)
        {
            Invoker invoker = new();
            invoker.SetOnStart(new SimpleCommand("Say Hi!"));

            Receiver receiver = new();
            invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));

            invoker.DoSomethingImportant();

            Console.ReadKey(true);
        }
    }
}

