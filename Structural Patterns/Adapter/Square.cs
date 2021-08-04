
using System;

namespace Adapter
{
    class SquarePeg
    {
        private readonly double width;
        public SquarePeg(double _width)
        {
            width = _width;
        }
        public double GetWidth()
        {
            return width;
        }
    }

    class SquarePegAdapter : RoundPeg
    {
        private readonly SquarePeg peg;
        public SquarePegAdapter(SquarePeg _peg)
        {
            peg = _peg;
        }
        public override double GetRadius()
        {
            return peg.GetWidth() * Math.Sqrt(2) / 2;
        }
    }
}

