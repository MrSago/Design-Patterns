
namespace Prototype
{
    abstract class Shape
    {
        protected readonly double X, Y;
        protected readonly string color;
        public Shape(double _x, double _y, string _color)
        {
            X = _x;
            Y = _y;
            color = _color;
        }
        public abstract Shape Clone();
        public abstract string GetInfo();
    }
}

