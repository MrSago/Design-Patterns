
using System;

namespace Command
{
    class Invoker
    {
        private ICommand _onStart;
        private ICommand _onFinish;

        public void SetOnStart(ICommand command)
        {
            _onStart = command;
        }
        public void SetOnFinish(ICommand command)
        {
            _onFinish = command;
        }

        public void DoSomethingImportant()
        {
            Console.WriteLine("Invoker: Does anybody want something done before I begin?");
            if (_onStart is ICommand)
            {
                _onStart.Execute();
            }

            Console.WriteLine("Invoker: ...doing something really important...");

            Console.WriteLine("Invoker: Does anybody want something done after I finish?");
            if (_onFinish is ICommand)
            {
                _onFinish.Execute();
            }
        }
    }
}

