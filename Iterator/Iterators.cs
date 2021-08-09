
using System.Collections;

namespace Iterator
{
    abstract class Iterator : IEnumerator
    {
        object IEnumerator.Current => Current();
        public abstract int Key();
        public abstract object Current();
        public abstract bool MoveNext();
        public abstract void Reset();
    }

    abstract class IteratorAggregate : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }

    class AlphabeticalOrderIterator : Iterator
    {
        private readonly WordsCollection _collection;
        private readonly bool _reverse;
        private int _position;

        public AlphabeticalOrderIterator(WordsCollection collection, bool reverse = false)
        {
            _collection = collection;
            _reverse = reverse;
            _position = -1;

            if (reverse)
            {
                _position = collection.GetItems().Count;
            }
        }

        public override object Current()
        {
            return _collection.GetItems()[_position];
        }

        public override int Key()
        {
            return _position;
        }

        public override bool MoveNext()
        {
            int updatedPosition = _position + (_reverse ? -1 : 1);

            if (updatedPosition >= 0 && updatedPosition < _collection.GetItems().Count)
            {
                _position = updatedPosition;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Reset()
        {
            _position = _reverse ? _collection.GetItems().Count - 1 : 0;
        }
    }
}

