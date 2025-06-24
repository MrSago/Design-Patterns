
using System;

namespace Memento
{
    interface IMemento
    {
        string GetName();
        string GetState();
        DateTime GetDate();
    }

    class ConcreteMemento(string state) : IMemento
    {
        private readonly string _state = state;
        private readonly DateTime _date = DateTime.Now;

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

