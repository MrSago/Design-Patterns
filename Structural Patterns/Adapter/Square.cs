
using System;

namespace Adapter
{
    class SquarePeg
    {
        private readonly double _width;
        public SquarePeg(double width)
        {
            _width = width;
        }
        public double GetWidth()
        {
            return _width;
        }
    }

    class SquarePegAdapter : RoundPeg
    {
        private readonly SquarePeg _peg;
        public SquarePegAdapter(SquarePeg peg)
        {
            _peg = peg;
        }
        public override double GetRadius()
        {
            return _peg.GetWidth() * Math.Sqrt(2) / 2;
        }
    }
}

