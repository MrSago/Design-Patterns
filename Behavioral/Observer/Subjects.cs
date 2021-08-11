
using System;
using System.Collections.Generic;
using System.Threading;

namespace Observer
{
    interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }

    class Subject : ISubject
    {
        private int _state = 0;
        public int State { get => _state; set => _state = value; }

        private readonly List<IObserver> _observers = new();

        public void Attach(IObserver observer)
        {
            Console.WriteLine("Subject: Attached an observer");
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            Console.WriteLine("Subject: Detached an observer");
            _observers.Remove(observer);
        }

        public void Notify()
        {
            Console.WriteLine("Subject: Notify observers...");

            foreach (var it in _observers)
            {
                it.Update(this);
            }
        }

        public void SomeBusinessLogic()
        {
            Console.WriteLine("\nSubject: I'm doing something important.");
            _state = new Random().Next(0, 10);

            Thread.Sleep(10);

            Console.WriteLine("Subject: My state has just changed to: " + _state);
            Notify();
        }
    }
}

