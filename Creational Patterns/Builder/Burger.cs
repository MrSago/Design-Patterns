
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
        private float size;
        public float Size { set { size = value; } }
        private readonly Dictionary<BurgerProps, uint> props;
        public Burger(float _size = 0.0f)
        {
            size = _size;
            props = new();
        }
        public void Add(BurgerProps _prop, uint _count)
        {
            if (props.ContainsKey(_prop))
            {
                props[_prop] += _count;
            }
            else
            {
                props[_prop] = _count;
            }
        }
        public void PrintProps()
        {
            Console.WriteLine($"size: {size}");
            foreach (var it in props)
            {
                Console.WriteLine($"{it.Key}: {it.Value}");
            }
            Console.Write('\n');
        }
    }
}

