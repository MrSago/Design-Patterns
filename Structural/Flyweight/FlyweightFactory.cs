
using System;
using System.Collections.Generic;
using System.Linq;

namespace Flyweight
{
    class FlyweightFactory
    {
        private readonly List<Tuple<Flyweight, string>> _flyweights = new();

        public FlyweightFactory(params Car[] args)
        {
            _flyweights.AddRange
            (
                from elem in args
                    select new Tuple<Flyweight, string>
                    (
                        new Flyweight(elem), GetKey(elem)
                    )
            );
        }

        private string GetKey(Car key)
        {
            List<string> elements = new();

            elements.Add(key.Model);
            elements.Add(key.Color);
            elements.Add(key.Company);

            if (key.Owner != null && key.Number != null)
            {
                elements.Add(key.Number);
                elements.Add(key.Owner);
            }

            elements.Sort();

            return string.Join("_", elements);
        }

        public Flyweight GetFlyweight(Car sharedState)
        {
            string key = GetKey(sharedState);

            if (!_flyweights.Any(t => t.Item2 == key))
            {
                Console.WriteLine("FlyweightFactory: Can't find a flyweight, creating new one.");
                _flyweights.Add(new Tuple<Flyweight, string>(
                                new Flyweight(sharedState), key));
            }
            else
            {
                Console.WriteLine("FlyweightFactory: Reusing existing flyweight.");
            }

            return _flyweights.Where(t => t.Item2 == key).FirstOrDefault().Item1;
        }

        public void ListFlyweights()
        {
            var count = _flyweights.Count;
            Console.WriteLine($"\nFlyweightFactory: I have {count} flyweights:");
            foreach (var flyweight in _flyweights)
            {
                Console.WriteLine(flyweight.Item2);
            }
        }
    }
}

