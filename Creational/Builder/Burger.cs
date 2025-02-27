using System;
using System.Collections.Generic;

namespace Builder;

enum BurgerProps
{
    Cheese,
    Pepperoni,
    Lettuce,
    Tomato,
}

class Burger(float size = 0.0f)
{
    private float _size = size;
    public float Size
    {
        set => _size = value;
    }

    private readonly Dictionary<BurgerProps, uint> _props = [];

    public Burger Add(BurgerProps prop, uint count)
    {
        if (!_props.ContainsKey(prop))
        {
            _props[prop] = count;
        }
        else
        {
            _props[prop] += count;
        }
        return this;
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
