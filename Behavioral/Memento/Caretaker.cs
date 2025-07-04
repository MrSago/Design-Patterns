﻿
using System;
using System.Collections.Generic;
using System.Linq;

namespace Memento
{
    class Caretaker(Originator originator)
    {
        private readonly List<IMemento> _mementos = [];
        private readonly Originator _originator = originator;

        public void Backup()
        {
            Console.WriteLine("Caretaker: Saving Originator's state...\n");
            _mementos.Add(_originator.Save());
        }

        public void Undo()
        {
            if (_mementos.Count == 0)
            {
                return;
            }

            var memento = _mementos.Last();
            _mementos.Remove(memento);

            Console.WriteLine("Caretaker: Restoring state to: " + memento.GetName());

            try
            {
                _originator.Restore(memento);
            }
            catch (Exception)
            {
                Undo();
            }
        }

        public void ShowHistory()
        {
            Console.WriteLine("Caretaker: Here's the list of mementos:");

            foreach (var memento in _mementos)
            {
                Console.WriteLine(memento.GetName());
            }
        }
    }
}

