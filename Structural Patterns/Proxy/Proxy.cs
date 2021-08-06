
using System;

namespace Proxy
{
    interface ISubject
    {
        void Request();
    }

    class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("RealSubject: Handling Request.");
        }
    }

    class Proxy : ISubject
    {
        private readonly RealSubject _realSubject;

        public Proxy()
        {
            _realSubject = new();
        }

        public Proxy(RealSubject realSubject)
        {
            _realSubject = realSubject;
        }

        public void Request()
        {
            if (CheckAccess())
            {
                _realSubject.Request();

                LogAccess();
            }
        }

        private bool CheckAccess()
        {
            Console.WriteLine("Proxy: Checking access prior to send a real request.");
            return true;
        }

        private void LogAccess()
        {
            Console.WriteLine("Proxy: Logging the time of request.");
        }
    }
}

