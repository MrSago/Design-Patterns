
using System;
using System.Collections.Generic;

namespace Builder
{
    enum BurgerProps
    {
        Cheese,
        Pepperoni,
        Lettuce,
        Tomato
    }

    class Burger
    {
        private float _size;
        public float Size { set => _size = value; }

        private readonly Dictionary<BurgerProps, uint> _props = new();

        public Burger(float size = 0.0f)
        {
            _size = size;
        }

        public void Add(BurgerProps prop, uint count)
        {
            if (!_props.ContainsKey(prop))
            {
                _props[prop] = count;
            }
            else
            {
                _props[prop] += count;
            }
        }

        public void PrintProps()
        {
            Console.WriteLine($"size: {_size}");
            foreach (var it in _props)
            {
                Console.WriteLine($"{it.Key}: {it.Value}");
            }
            Console.Write('\n');
        }
    }
}

