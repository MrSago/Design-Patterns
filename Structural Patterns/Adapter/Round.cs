
namespace Adapter
{
    class RoundHole
    {
        private readonly double _radius;
        public RoundHole(double raidus)
        {
            _radius = raidus;
        }
        public bool Fits(RoundPeg peg)
        {
            return _radius >= peg.GetRadius();
        }
    }

    class RoundPeg
    {
        private readonly double _radius;
        public RoundPeg(double radius = -1.0)
        {
            _radius = radius;
        }
        public virtual double GetRadius()
        {
            return _radius;
        }
    }
}

