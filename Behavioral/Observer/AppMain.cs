
using System;

namespace Observer
{
    static class AppMain
    {
        static void Main()
        {
            Subject subject = new();
            ConcreateObserverA observerA = new();
            ConcreateObserverB observerB = new();

            subject.Attach(observerA);
            subject.Attach(observerB);

            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();

            subject.Detach(observerB);
            subject.SomeBusinessLogic();

            _ = Console.ReadKey(true);
        }
    }
}

