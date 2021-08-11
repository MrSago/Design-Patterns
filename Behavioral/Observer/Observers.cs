
using System;

namespace Observer
{
    interface IObserver
    {
        void Update(ISubject subject);
    }

    class ConcreateObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State is < 5)
            {
                Console.WriteLine("ConcreteObserverA: Reacted to the event.");
            }
        }
    }

    class ConcreateObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State is 0 or >= 2)
            {
                Console.WriteLine("ConcreteObserverB: Reacted to the event.");
            }
        }
    }
}

