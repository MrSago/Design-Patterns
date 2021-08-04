
namespace Adapter
{
    class RoundHole
    {
        private readonly double radius;
        public RoundHole(double _raidus)
        {
            radius = _raidus;
        }
        public bool Fits(RoundPeg _peg)
        {
            return radius >= _peg.GetRadius();
        }
    }

    class RoundPeg
    {
        private readonly double radius;
        public RoundPeg(double _radius = -1.0)
        {
            radius = _radius;
        }
        public virtual double GetRadius()
        {
            return radius;
        }
    }
}

