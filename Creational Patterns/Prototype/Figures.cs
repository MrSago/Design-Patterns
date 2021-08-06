
namespace Prototype
{
    class Rectangle : Shape
    {
        private readonly double _width, _height;

        public Rectangle(double x, double y, string color, double width, double height) :
            base(x, y, color)
        {
            _width = width;
            _height = height;
        }

        public override Shape Clone() => (Rectangle)MemberwiseClone();

        public override string GetInfo()
        {
            return $"It's {GetType().Name}: Width={_width}, Heigth={_height}\n" +
                   $"X={_x}, Y={_y}, color={_color}\n";
        }
    }

    class Circle : Shape
    {
        private readonly double _radius;

        public Circle(double x, double y, string color, double radius) :
            base(x, y, color)
        {
            _radius = radius;
        }

        public override Shape Clone() => (Circle)MemberwiseClone();

        public override string GetInfo()
        {
            return $"It's {GetType().Name}: Radius={_radius}\n" +
                   $"X={_x}, Y={_y}, color={_color}\n";
        }
    }
}

