
using System;

namespace Memento
{
    interface IMemento
    {
        string GetName();
        string GetState();
        DateTime GetDate();
    }

    class ConcreteMemento : IMemento
    {
        private readonly string _state;
        private readonly DateTime _date;

        public ConcreteMemento(string state)
        {
            _state = state;
            _date = DateTime.Now;
        }

        public string GetState()
        {
            return _state;
        }

        public string GetName()
        {
            return $"{_date} / {_state}";
        }

        public DateTime GetDate()
        {
            return _date;
        }
    }
}

