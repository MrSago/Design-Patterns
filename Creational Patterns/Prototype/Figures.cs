
namespace Prototype
{
    class Rectangle : Shape
    {
        private readonly double Width, Height;
        public Rectangle(double _x, double _y, string _color, double _width, double _height) :
            base(_x, _y, _color)
        {
            Width = _width;
            Height = _height;
        }
        public override Shape Clone()
        {
            return (Rectangle)MemberwiseClone();
        }
        public override string GetInfo()
        {
            return $"It's {GetType().Name}: Width={Width}, Heigth={Height}\n" +
                   $"X={X}, Y={Y}, color={color}\n";
        }
    }

    class Circle : Shape
    {
        private readonly double Radius;
        public Circle(double _x, double _y, string _color, double _radius) :
            base(_x, _y, _color)
        {
            Radius = _radius;
        }
        public override Shape Clone()
        {
            return (Circle)MemberwiseClone();
        }
        public override string GetInfo()
        {
            return $"It's {GetType().Name}: Radius={Radius}\n" +
                   $"X={X}, Y={Y}, color={color}\n";
        }
    }
}

