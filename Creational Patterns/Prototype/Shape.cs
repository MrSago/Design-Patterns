
namespace Prototype
{
    abstract class Shape
    {
        protected readonly double _x, _y;
        protected readonly string _color;

        public Shape(double x, double y, string color)
        {
            _x = x;
            _y = y;
            _color = color;
        }

        public abstract Shape Clone();
        public abstract string GetInfo();
    }
}

