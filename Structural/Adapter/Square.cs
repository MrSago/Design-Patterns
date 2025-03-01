using System;

namespace Adapter;

class SquarePeg(double width)
{
    private readonly double _width = width;

    public double GetWidth()
    {
        return _width;
    }
}

class SquarePegAdapter(SquarePeg peg) : RoundPeg
{
    private readonly SquarePeg _peg = peg;

    public override double GetRadius()
    {
        return _peg.GetWidth() * Math.Sqrt(2) / 2;
    }
}
