namespace Adapter;

class RoundHole(double raidus)
{
    private readonly double _radius = raidus;

    public bool Fits(RoundPeg peg)
    {
        return _radius >= peg.GetRadius();
    }
}

class RoundPeg(double radius = -1.0)
{
    private readonly double _radius = radius;

    public virtual double GetRadius()
    {
        return _radius;
    }
}
