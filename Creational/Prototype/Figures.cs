namespace Prototype;

class Rectangle(double x, double y, string color, double width, double height) : Shape(x, y, color)
{
    private readonly double _width = width,
        _height = height;

    public override Shape Clone() => (Rectangle)MemberwiseClone();

    public override string GetInfo()
    {
        return $"It's {nameof(Rectangle)}: Width={_width}, Heigth={_height}\n"
            + $"X={_x}, Y={_y}, color={_color}\n";
    }
}

class Circle(double x, double y, string color, double radius) : Shape(x, y, color)
{
    private readonly double _radius = radius;

    public override Shape Clone() => (Circle)MemberwiseClone();

    public override string GetInfo()
    {
        return $"It's {nameof(Circle)}: Radius={_radius}\n" + $"X={_x}, Y={_y}, color={_color}\n";
    }
}
