namespace Prototype;

abstract class Shape(double x, double y, string color)
{
    protected readonly double _x = x;
    protected readonly double _y = y;
    protected readonly string _color = color;

    public abstract Shape Clone();
    public abstract string GetInfo();
}
